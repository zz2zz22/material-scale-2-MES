using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialScale2MES
{
    public class SupportClass
    {
        public static void LoadData2DTGVChooseWO(DataGridView dataGridView, DataTable dt)
        {
            dataGridView.DataSource = dt;
            dataGridView.Columns["ID"].Visible = false;
            dataGridView.Columns["jobOrdUUID"].Visible = false;
            dataGridView.Columns["orderNo"].HeaderText = "Mã ERP";
            dataGridView.Columns["jobNo"].HeaderText = "Mã đơn";
            dataGridView.Columns["prodNo"].HeaderText = "Mã sản phẩm";
            
            dataGridView.Columns["orderQty"].HeaderText = "Số lượng của đơn";
            dataGridView.Columns["finishQty"].HeaderText = "Số lượng đã làm";

            dataGridView.Columns["createDate"].HeaderText = "Ngày tạo đơn";
        }

        public static void LoadData2DTGVScannedMat(DataGridView dataGridView, DataTable dt)
        {
            dataGridView.DataSource = dt;
            dataGridView.Columns["MatCode"].HeaderText = "Mã liệu";
            dataGridView.Columns["SubMat"].HeaderText = "Liệu phụ";
            dataGridView.Columns["ExpDate"].HeaderText = "Hạn liệu";
            dataGridView.Columns["LOT"].HeaderText = "Số LOT";
            dataGridView.Columns["SumScale"].HeaderText = "Tổng KL Cân";
            
        }
    }
}
