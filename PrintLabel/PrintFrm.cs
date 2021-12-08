using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintLabel
{
    public partial class PrintFrm : Form
    {

        private Bitmap m_bitmap;

        public PrintFrm(Bitmap bitmap)
        {
            InitializeComponent();
            m_bitmap = bitmap;
            pictureBoxLabel.Image = bitmap;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (this.printDialogUC.ShowDialog() == DialogResult.OK)
            {
                this.Invoke(new Action(() =>
                {
                    this.printDocumentUC.Print();
                }));
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            this.pageSetupDialogUC.ShowDialog();
        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            this.printPreviewDialogUC.ShowDialog();
        }

        private void printDocumentUC_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(m_bitmap, 0, 0, m_bitmap.Width, m_bitmap.Height);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
