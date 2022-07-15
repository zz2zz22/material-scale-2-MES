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
            dataGridView.Columns["orderNo"].HeaderText = "Mã đơn";
            dataGridView.Columns["prodNo"].HeaderText = "Mã sản phẩm";
            dataGridView.Columns["prodName"].HeaderText = "Tên sản phẩm";
            dataGridView.Columns["saleNo"].HeaderText = "Mã sale";
            dataGridView.Columns["orderQty"].HeaderText = "Số lượng của đơn";
            dataGridView.Columns["dispatchQty"].HeaderText = "Số lượng sinh quản phát";
            dataGridView.Columns["finishQty"].HeaderText = "Số lượng đã hoàn thành";
            dataGridView.Columns["remainQty"].HeaderText = "Số lượng cần làm";
            dataGridView.Columns["createDate"].HeaderText = "Ngày tạo đơn";
        }
    }
}
