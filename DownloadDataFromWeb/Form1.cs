using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace DownloadDataFromWeb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient myweb = new WebClient();
            string url = "file:///C:/Users/Joe/Desktop/FireBase/FireBaseTest.html";
            byte[] datas = myweb.DownloadData(url);
            string download = Encoding.ASCII.GetString(datas);
            string Content = myweb.DownloadString(url);
            richTextBox1.Text = Content;
            MessageBox.Show("ALL gud");
        }
    }
}
