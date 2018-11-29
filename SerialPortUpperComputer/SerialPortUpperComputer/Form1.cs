using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SerialPortUpperComputer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Process.Start("explorer", "https://www.baidu.com");
            Process.Start("explorer", "https://www.taobao.com");
            this.Close();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fileDialog = new FolderBrowserDialog();

            //fileDialog. = true;
            //fileDialog.Title = "请选择项目要保存的目录";
           // fileDialog.Filter = "所有文档|*.*";
            //fileDialog.InitialDirectory=//设置初始目录

            if(fileDialog.ShowDialog()==DialogResult.OK)
            {
                //string file1 = fileDialog.FileName;
                string file2 = fileDialog.SelectedPath;
            }
        }
    }
}
