
namespace PrintLabel.FanfanControl
{
    partial class WebApiDataDisplayUC
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewUC = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUC)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUC
            // 
            this.dataGridViewUC.AllowUserToAddRows = false;
            this.dataGridViewUC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewUC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUC.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUC.Name = "dataGridViewUC";
            this.dataGridViewUC.RowTemplate.Height = 23;
            this.dataGridViewUC.Size = new System.Drawing.Size(519, 256);
            this.dataGridViewUC.TabIndex = 0;
            this.dataGridViewUC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUC_CellContentClick);
            // 
            // WebApiDataDisplayUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewUC);
            this.Name = "WebApiDataDisplayUC";
            this.Size = new System.Drawing.Size(519, 256);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUC;
    }
}
