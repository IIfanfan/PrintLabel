using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintLabel.FanfanControl
{
    public partial class WebApiDataDisplayUC : UserControl
    {
        public DataTable MyDataTable { get; set; }

        public WebApiDataDisplayUC()
        {
            InitializeComponent();

            DataGridViewCheckBoxColumn checkColum = new DataGridViewCheckBoxColumn();
            checkColum.HeaderText = "选择";
            checkColum.Name = "Choose";
            checkColum.DataPropertyName = "Choose";
            checkColum.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            checkColum.ReadOnly = false;
            checkColum.TrueValue = "1";
            checkColum.FalseValue = "0";
            checkColum.Width = 50;
            dataGridViewUC.Columns.Add(checkColum);
            DataGridViewTextBoxColumn SliceCol = new DataGridViewTextBoxColumn();
            SliceCol.HeaderText = "片号";
            SliceCol.Name = "SliceNum";
            SliceCol.DataPropertyName = "SliceNum";
            SliceCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            SliceCol.ReadOnly = true;
            SliceCol.Width = 200;
            dataGridViewUC.Columns.Add(SliceCol);
        }

        public void UpdateDataGridView()
        {
            dataGridViewUC.DataSource = MyDataTable;
            dataGridViewUC.Refresh();
        }

        private void dataGridViewUC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                if (this.dataGridViewUC.Rows[e.RowIndex].Cells["Choose"].Value.ToString() == "1")
                {
                    this.dataGridViewUC.Rows[e.RowIndex].Cells["Choose"].Value = "0";
                }
                else
                {
                    this.dataGridViewUC.Rows[e.RowIndex].Cells["Choose"].Value = "1";
                }
                MyDataTable = (DataTable)dataGridViewUC.DataSource;
                PrinterDataClass.PrinterConnect = MyDataTable;
            }
        }
    }
}
