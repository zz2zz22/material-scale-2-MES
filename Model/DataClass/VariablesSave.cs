using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialScale2MES
{
    public class VariablesSave
    {
        //Employee Save
        public static String empName { get; set; }
        public static String empCode { get; set; }
        public static String empID { get; set; }

        //Material Save
        public static String matCode { get; set; }
        public static String matName { get; set; }
        public static String matLotNo { get; set; }
        public static String matExpDate { get; set; }
        public static double matScanQuantity { get; set; } //Quantity on QR code scan
        public static double matActualQuantity { get; set; } //On scale quantity 

        //DeptID Save
        public static String deptUUID { get; set; }
        public static String JobOrdUUID { get; set; }

        //Job order material UUIDs save 
        public static String[] MatOrder { get; set; } 

        //Reset Employee Savedata
        public static void ResetEmployee()
        {
            empName = null;
            empCode = null;
            empID = null;
        }
        //Reset Material Savedata
        public static void ResetMaterial()
        {
            matCode = null;
            matName = null;
            matExpDate = null;
            matLotNo = null;
            matScanQuantity = 0;
            matActualQuantity = 0;
        }

        //Reset Dept Savedata
        public static void ResetDept()
        {
            JobOrdUUID = null;
            deptUUID = null;
        }

        //Reset JobOrd Mat Savedata 
        public static void ResetJobOrdMat()
        {
            MatOrder = null;
        }
    }
}
