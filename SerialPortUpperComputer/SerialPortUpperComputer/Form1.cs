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
using System.IO;

namespace SerialPortUpperComputer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //textBoxShowSelectedPath.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            //Process.Start("explorer", "https://www.baidu.com");
            //Process.Start("explorer", "https://www.taobao.com");
            this.Close();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            var fileDialog = new FolderBrowserDialog();
            
            //fileDialog. = true;
            //fileDialog.Title = "请选择项目要保存的目录";
           // fileDialog.Filter = "所有文档|*.*";
            //fileDialog.InitialDirectory=//设置初始目录

            if(fileDialog.ShowDialog()==DialogResult.OK)
            {
                //string file1 = fileDialog.FileName;
                string file2 = fileDialog.SelectedPath;
                textBoxShowSelectedPath.Text = file2;
            }
        }


        private void createPRJ_Click(object sender, EventArgs e)
        {
            string textBoxString = textBoxShowSelectedPath.Text;
            if (textBoxString=="")
            {
                MessageBox.Show("请选择一个文件路径！");
            }
            else
            {
                //var fileDialog = new FolderBrowserDialog();
                if (Directory.Exists(textBoxString)==true)
                {
                    MessageBox.Show("目录存在");
                }
                else
                {
                    MessageBox.Show("目录不存在");
                }
                
            }
        }
    }
}
