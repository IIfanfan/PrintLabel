using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;

namespace PrintLabel.FanfanControl
{
    public partial class PrintButton : UserControl
    {
        public PrintButton()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 把Html文件ImageName替换成ImagePath
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="ImageName"></param>
        private void ExchangeHtmlContent(string fileName,string ImageName)
        {
            Stream myStream = new FileStream(fileName, FileMode.Open);
            Encoding encode = System.Text.Encoding.GetEncoding("GB2312");
            StreamReader myStreamReader = new StreamReader(myStream, encode);
            string strhtml = myStreamReader.ReadToEnd();
            var imageStartChar = strhtml.IndexOf("Image") +  6;  //加上本身的字符
            var imageEndChar = strhtml.IndexOf(".jpg");   //用于结尾

            var lastImageName = strhtml.Substring(imageStartChar, (imageEndChar - imageStartChar) + 4);
            string stroutput = strhtml.Replace(lastImageName, ImageName + ".jpg");
            myStream.Seek(0, SeekOrigin.Begin);
            myStream.SetLength(0);
            StreamWriter sw = new StreamWriter(myStream, encode);
            sw.Write(stroutput);
            sw.Flush();
            sw.Close();
            myStream.Close();
        }
        /// <summary>
        /// 生成标签图片
        /// </summary>
        /// <param name="text"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="fileName"></param>
        private Bitmap Generate(string text, int width, int height, string fileName = null)
        {
            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.CODE_128;
            EncodingOptions options = new EncodingOptions()
            {
                Width = width,
                Height = height,
                Margin = 2
            };
            writer.Options = options;
            writer.Options.PureBarcode = true;
            Bitmap map = writer.Write(text);
            return map;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < PrinterDataClass.PrinterConnect.Rows.Count; i++)
            {
                if (PrinterDataClass.PrinterConnect.Rows[i]["Choose"].ToString() == "1")
                {
                    Bitmap bitmap =  Generate(PrinterDataClass.PrinterConnect.Rows[i]["SliceNum"].ToString(), 130, 20, ConfigurationManager.AppSettings["ImagePath"]);
                    PrintFrm printUC = new PrintFrm(bitmap);
                    printUC.ShowDialog();
                }
            }
        }
    }
}
