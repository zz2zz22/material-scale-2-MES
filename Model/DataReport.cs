using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using ClosedXML.Excel;
using System.IO;
using System.Net.Mail;
using System.Runtime.InteropServices;

namespace MaterialScale2MES
{
    public class DataReport
    {
        static DataReport s_drInstance = null;

        DataTable successReportTB = null;
        //DataTable failReportTB = null;

        public enum RP_TYPE
        {
            Success
        };

        private DataReport()
        {
            successReportTB = new DataTable();

            DataColumn cl1 = new DataColumn();
            cl1.ColumnName = "Thời gian chuyển MES"; //DateTime.Now
            cl1.DataType = typeof(string);

            DataColumn cl2 = new DataColumn();
            cl2.ColumnName = "ID đơn liệu trên MES"; // Loại phiếu
            cl2.DataType = typeof(string);

            DataColumn cl3 = new DataColumn();
            cl3.ColumnName = "Mã đơn làm việc"; // Mã phiếu
            cl3.DataType = typeof(string);

            DataColumn cl4 = new DataColumn();
            cl4.ColumnName = "Mã liệu chính";
            cl4.DataType = typeof(string);

            DataColumn cl5 = new DataColumn();
            cl5.ColumnName = "Mã liệu phụ";
            cl5.DataType = typeof(string);

            DataColumn cl6 = new DataColumn();
            cl6.ColumnName = "Số lượng thực tế";
            cl6.DataType = typeof(string);

            DataColumn cl7 = new DataColumn();
            cl7.ColumnName = "Ngày hết hạn (Theo liệu chính)";
            cl7.DataType = typeof(string);

            DataColumn cl8 = new DataColumn();
            cl8.ColumnName = "Số LOT";
            cl8.DataType = typeof(string);

            DataColumn cl9 = new DataColumn();
            cl9.ColumnName = "Mã danh sách liệu trả";
            cl9.DataType = typeof(string);

            DataColumn cl10 = new DataColumn();
            cl10.ColumnName = "Trạng thái chuyển đổi";
            cl10.DataType = typeof(string);

            successReportTB.Columns.AddRange(new DataColumn[] { cl1, cl2, cl3, cl4, cl5, cl6, cl7, cl8, cl9, cl10 });
        }

        public static void addReport(RP_TYPE rpType, string transDate, string jobMatUUID, string jobNo, string mainMatNo, string subMatNo, string actualWeight, string expDate, string lotNo, string matReturnListNo, string status)
        {
            if (s_drInstance == null)
            {
                s_drInstance = new DataReport();
            }
            s_drInstance.writeReport(rpType, transDate, jobMatUUID, jobNo, mainMatNo, subMatNo, actualWeight, expDate, lotNo, matReturnListNo, status);
        }

        private void writeReport(RP_TYPE rpType, string transDate, string jobMatUUID, string jobNo, string mainMatNo, string subMatNo, string actualWeight, string expDate, string lotNo, string matReturnListNo, string status)
        {
            switch (rpType)
            {
                case RP_TYPE.Success:
                    successReportTB.Rows.Add(new object[] { transDate, jobMatUUID, jobNo, mainMatNo, subMatNo, actualWeight, expDate, lotNo, matReturnListNo, status });
                    break;
                default:
                    break;
            }
        }

        public static void SaveExcel(string excelFilePath, string fileName)
        {
            if (s_drInstance == null)
            {
                s_drInstance = new DataReport();
            }
            string sender = "tlms@techlink.vn";
            string sender_pw = "techlink@123";
            s_drInstance.ExportToExcel(excelFilePath, fileName);
            s_drInstance.SendReport(sender, sender_pw);
            s_drInstance = null;
        }

        public void ExportToExcel(string excelFilePath, string fileName)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\Material2MES_Reports";
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
            if (dir.Exists == false)
                dir.Create();

            XLWorkbook wb = new XLWorkbook();
            var ws1 = wb.Worksheets.Add(successReportTB, "Success MO");
            
            wb.Style.Fill.BackgroundColor = XLColor.NoColor;

            ws1.Column("A").Width = 19;
            ws1.Column("B").Width = 19;
            ws1.Column("C").Width = 19;
            ws1.Column("D").Width = 19;
            ws1.Column("E").Width = 19;
            ws1.Column("F").Width = 19;
            ws1.Column("G").Width = 19;
            ws1.Column("H").Width = 19;
            ws1.Column("I").Width = 19;
            ws1.Column("J").Width = 19;
            ws1.Column("K").Width = 40;

            if (!string.IsNullOrEmpty(excelFilePath))
            {
                try
                {
                    wb.SaveAs(Path.Combine(excelFilePath, fileName));
                    Properties.Settings.Default.excelFileName = Path.Combine(excelFilePath, fileName);
                    Properties.Settings.Default.Save();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            { // no file path is given
                wb.SaveAs(Path.Combine(path, fileName));
                Properties.Settings.Default.excelFileName = Path.Combine(path, fileName);
                Properties.Settings.Default.Save();
            }
            wb.Dispose();
        }
        public void SendReport(string sender, string sender_pw)
        {
            string smtp = sender.Substring(sender.IndexOf('@'));
            string smtp_server = "";
            string smtp_port = "";
            if (smtp == "@gmail.com")
            {
                smtp_server = "smtp.gmail.com";
                smtp_port = "587";
            }
            else if (smtp == "@techlink.vn")
            {
                smtp_server = "pro56.emailserver.vn";
                smtp_port = "587";
            }

            Properties.Settings.Default.Save();
            //string[] receivers = Properties.Settings.Default.cfg_receivers.Split('-');
            //for (int i = 0; i < receivers.Length; i++)
            //{
                
            //}
            MailMessage mail = new MailMessage();

            SmtpClient SmtpServer = new SmtpClient(smtp_server);
            mail.From = new MailAddress(sender);
            mail.To.Add("dragonslayer3105@gmail.com");
            mail.Subject = "Material to MES Software transfer report : " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            mail.Body = "This is an auto generated report! Please don't reply!";

            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment(Properties.Settings.Default.excelFileName);
            mail.Attachments.Add(attachment);

            SmtpServer.Port = int.Parse(smtp_port);
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Credentials = new System.Net.NetworkCredential(sender, sender_pw);
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
            mail.Dispose();
        }
    }
}
