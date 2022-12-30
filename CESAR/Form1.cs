using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using System.Windows.Forms;

namespace CESAR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dadosIni = File.ReadLines(@"C:\Conceito\CIE\CIE.INI");
            var dadosIni2 = dadosIni.ToList<string>();
            foreach (var item in dadosIni)
            {
                item.Contains("database");
            };
            FbConnection cesar = new FbConnection(@"datasource=10.100.20.18/3050;database=/opt/firebird/data/Sandro/SANDRO.FDB;user=sysdba;password=masterkey");
            cesar.Open();
            FbCommand cmd = new FbCommand("select * from nf_tmp",cesar);
            cmd.ExecuteNonQuery();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
