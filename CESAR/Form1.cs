using System;
using System.IO;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;


namespace CESAR
{
    public partial class Form1 : Form
    {
        string caminho = "EMPTY";
        string datasource = "localhost";
        string database = @"C:\Conceito\DB\*.FDB";
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
            FbConnection cesar = new FbConnection($@"datasource=localhost;{caminho};user=SYSDBA;password=masterkey");
            cesar.Open();
            FbCommand cmd = new FbCommand("update nota_fiscal n set n.nf_datasaida = current_date, n.nf_emissao = current_date where n.status_nfe in ('D','T') and n.nf_emissao < current_date",cesar);
            cmd.ExecuteNonQuery();
            if (caminho.Equals("EMPTY"))
            {
                label3.Visible = false;
            }
            else
            {
                label3.Visible = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {               
            openFileDialog1.ShowDialog();
            label7.Text = openFileDialog1.FileName;
            string[] array = File.ReadAllLines(label7.Text);
            foreach (string item in array)
            {
                caminho = item.StartsWith("database") ? item : caminho;
            };
            //Localizar no INI a datasource (localhost ou IP)
            label7.Text = caminho;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
