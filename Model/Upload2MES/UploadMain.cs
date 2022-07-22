using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySqlConnector;
using System.Data;
using System.Windows.Forms;

namespace MaterialScale2MES
{
    public class UploadMain
    {
        int nextNo;
        public static string Date;
        public string updateAutoCodeHis(string empCode) //return SQL query to update 
        {
            try
            {
                nextNo = 0;
                sqlMesBaseDataCon sqlMesBaseData = new sqlMesBaseDataCon();
                StringBuilder sqlUpdateAutoCodeHis = new StringBuilder();
                string curNumStr = sqlMesBaseData.sqlExecuteScalarString("SELECT current_number FROM mes_base_data.autocode_his WHERE autocode_rule_uuid = '4E8DQFCD9BK1' AND delete_flag = '0'");
                if (!String.IsNullOrEmpty(curNumStr))
                {
                    if (int.TryParse(curNumStr, out int curNo))
                    {
                        curNo = int.Parse(curNumStr);
                        nextNo = curNo + 1;

                        sqlUpdateAutoCodeHis.Append(@"update autocode_his set current_number = '" + nextNo + "', update_by = '" + empCode + "', update_date  = '" + Date + "' where autocode_rule_uuid = '4E8DQFCD9BK1' AND delete_flag = '0'");
                    }
                    else
                    {
                        throw new ArgumentException("Cannot get the current autocode info!");
                    }
                }
                return sqlUpdateAutoCodeHis.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Update to autocode_his: Exception thrown!");
                return null;
            }
        }

        public string insertJobOrderMat(DataTable matDT)
        {
            try
            {
                sqlMesPlanningExcutionCon sqlMesPlanningExcution = new sqlMesPlanningExcutionCon();
                sqlMesBaseDataCon sqlMesBaseData = new sqlMesBaseDataCon();
                StringBuilder sqlInsertJOrderMat = new StringBuilder();
                // Get or Generate data to insert to job_order_material for each line of data in tempMat datatable
                if (matDT.Rows.Count > 0)
                {
                    string jobOrderMatUUID, jobOrderUUID, actMaterialNo, actMaterialUUID, actMaterialName, actMatUnitID, subMatNo, subMatUUID, subMatName, actMaterialLOT, matExpDate;
                    decimal actBeginMatQty;
                    if (!String.IsNullOrEmpty(VariablesSave.JobOrdUUID))
                    {
                        jobOrderUUID = VariablesSave.JobOrdUUID;
                    }
                    else
                    {
                        throw new ArgumentException("Job Order UUID cannot be null");
                    }
                    for (int i = 0; i < matDT.Rows.Count; i++)
                    {
                        bool isMissingData = false;
                        jobOrderMatUUID = UUIDGenerator.getAscId();
                        actMaterialNo = matDT.Rows[i]["MatCode"].ToString();
                        actMaterialUUID = sqlMesBaseData.sqlExecuteScalarString("SELECT material_uuid FROM material_info WHERE material_no = '" + actMaterialNo + "' AND delete_flag = '0'");
                        actMaterialName = sqlMesBaseData.sqlExecuteScalarString("SELECT material_name FROM material_info WHERE material_uuid = '" + actMaterialNo + "' AND delete_flag = '0'");
                        actMatUnitID = sqlMesBaseData.sqlExecuteScalarString("SELECT unit_uuid FROM material_info WHERE material_uuid = '" + actMaterialNo + "' and delete_flag = '0'");
                        //Check if order have subtitute material ?
                        if (!String.IsNullOrEmpty(matDT.Rows[i]["SubMat"].ToString()))
                        {
                            subMatNo = matDT.Rows[i]["SubMat"].ToString();
                            subMatUUID = sqlMesBaseData.sqlExecuteScalarString("SELECT material_uuid FROM material_info WHERE material_no = '" + subMatNo + "' AND delete_flag = '0'");
                            subMatName = sqlMesBaseData.sqlExecuteScalarString("SELECT material_name FROM material_info WHERE material_uuid = '" + subMatNo + "' AND delete_flag = '0'");
                        }
                        else
                        {
                            //Generate null values
                            subMatNo = null;
                            subMatUUID = null;
                            subMatName = null;
                        }
                        actMaterialLOT = matDT.Rows[i]["LOT"].ToString();
                        string[] tempExpDate = matDT.Rows[i]["ExpDate"].ToString().Split('/');
                        matExpDate = tempExpDate[2] + "-" + tempExpDate[1] + "-" + tempExpDate[0];
                        actBeginMatQty = (decimal)matDT.Rows[i]["SumScale"];

                        if (String.IsNullOrEmpty(actMaterialUUID) == true || String.IsNullOrEmpty(actMaterialName) == true || String.IsNullOrEmpty(actMaterialLOT) == true)
                        {
                            isMissingData = true;
                        }
                    }
                }

                return sqlInsertJOrderMat.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert to job_order_material: Exception thrown!");
                return null;
            }
        }

        public static void transactionSupportUploadData()
        {
            Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            MySqlConnection conn1 = DatabaseUtils.GetMes_Base_DataDBC();
            MySqlConnection conn2 = DatabaseUtils.GetMes_Planning_ExcutionDBC();
            MySqlTransaction trans1 = null;
            MySqlTransaction trans2 = null;
            MySqlCommand cmdMS1 = new MySqlCommand();
            MySqlCommand cmdMS2 = new MySqlCommand();
            try
            {
                //Init connection to MES database with admin connection to edit data
                conn1.Open();
                conn2.Open();
                trans1 = conn1.BeginTransaction();
                trans2 = conn2.BeginTransaction();
                cmdMS1.Transaction = trans1;
                cmdMS2.Transaction = trans2;
                cmdMS1.Connection = conn1;
                cmdMS2.Connection = conn2;
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
