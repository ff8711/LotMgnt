using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows;

namespace LotteryMgnt
{
    public partial class CustomerTrans : Form
    {
        public CustomerTrans()
        {
            InitializeComponent();
        }
        private void ReadOnlyColumm()
        {
            foreach (DataGridViewColumn col in dgLotIn.Columns)
                col.ReadOnly = true;
        }
        private void AllowEditColummFormat()
        {
            dgLotIn.EnableHeadersVisualStyles = false;
            dgLotIn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgLotIn.Columns["PRICE"].HeaderCell.Style.ForeColor = Color.Blue;
            dgLotIn.Columns["PRICE"].ReadOnly = false;
            dgLotIn.Columns["PRICE"].DefaultCellStyle.Format = "#,###";

            dgLotIn.Columns["QUANTITY"].HeaderCell.Style.ForeColor = Color.Blue;
            dgLotIn.Columns["QUANTITY"].ReadOnly = false;
            dgLotIn.Columns["QUANTITY"].DefaultCellStyle.Format = "#,###";

            dgLotIn.Columns["AMOUNT"].HeaderCell.Style.ForeColor = Color.Blue;
            dgLotIn.Columns["AMOUNT"].ReadOnly = false;
            dgLotIn.Columns["AMOUNT"].DefaultCellStyle.Format = "#,###";

            dgLotIn.Columns["AMOUNT"].DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#EFF0F1");
            dgLotIn.Columns["SEARCH NAME"].DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#EFF0F1");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            dgLotIn.DataSource = DataProvider.NewLotIn(dtpLotIn.Text);
            this.ReadOnlyColumm();
            this.AllowEditColummFormat();
            dgLotIn.Columns["PRICE"].ReadOnly = false;

        }

        private void CustomerTrans_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgLotIn.Rows[2];
            row.Cells[2].Value = "abc";
            row.Cells["AMOUNT"].Value = "123";
        }

        private void dgLotIn_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            int ColInd = dgLotIn.CurrentCell.ColumnIndex;
            int RowInd = dgLotIn.CurrentCell.RowIndex;
            int ColIndAmount = dgLotIn.Columns["AMOUNT"].Index;
            string colName = dgLotIn.Columns[ColInd].Name;
            float qty, price, amount;

            if ((colName == "QUANTITY") || (colName == "PRICE"))
            {
                //dgLotIn.Rows[RowInd].Cells["Amount"].Value = ((float)dgLotIn.Rows[RowInd].Cells["QUANTITY"].Value * (float)dgLotIn.Rows[RowInd].Cells["PRICE"].Value).ToString();
                qty = float.Parse(dgLotIn.Rows[RowInd].Cells["QUANTITY"].Value.ToString());
                price = float.Parse(dgLotIn.Rows[RowInd].Cells["PRICE"].Value.ToString());
                amount = qty * price;

                DataGridViewRow row = dgLotIn.Rows[RowInd];
                //MessageBox.Show(amount.ToString());
                row.Cells[ColIndAmount].Value = amount.ToString();
                //dgLotIn.EndEdit();

            }
        }

        private void dgLotIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddLine_Click(object sender, EventArgs e)
        {
            int maxRow = dgLotIn.RowCount-1;
            //MessageBox.Show(maxRow.ToString());
            dgLotIn.Rows[maxRow].Cells[0].ReadOnly = false;



        }

        private void btnPost_Click(object sender, EventArgs e)
        {

        }
    }
}
