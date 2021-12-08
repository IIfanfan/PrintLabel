using PrintLabel.FanfanControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ControlBox = false;
            skinEngine1.SkinFile = System.Environment.CurrentDirectory + "\\Skins\\Warm.ssk";

            DataTable dt = new DataTable("Table_New");
            //创建列
            dt.Columns.Add("Choose", System.Type.GetType("System.String"));
            dt.Columns.Add("SliceNum", System.Type.GetType("System.String"));
            //创建行
            dt.Rows.Add("1", "32412");
            dt.Rows.Add("0", "324124");
            dt.Rows.Add("0", "324124");
            dt.Rows.Add("0", "324124");
            dt.Rows.Add("0", "324124");
            dataDisplayUC.MyDataTable = dt;
            PrinterDataClass.PrinterConnect = dt;
            dataDisplayUC.UpdateDataGridView();
        }

        private void btnRset_Click(object sender, EventArgs e)
        {
            dataDisplayUC.MyDataTable = PrinterDataClass.PrinterConnect;
            dataDisplayUC.UpdateDataGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable newDataTable = new DataTable();
            //创建列
            newDataTable.Columns.Add("Choose", System.Type.GetType("System.String"));
            newDataTable.Columns.Add("SliceNum", System.Type.GetType("System.String"));
            var printLots = PrinterDataClass.PrinterConnect.Select("SliceNum = '" + tBLots.Text + "'");
            if (printLots.Length > 0)
            {
                foreach (var item in printLots)
                {
                    newDataTable.Rows.Add(item.ItemArray);//对新的dt赋值
                }
            }
            dataDisplayUC.MyDataTable = newDataTable;
            dataDisplayUC.UpdateDataGridView();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
