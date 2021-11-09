using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Indigo
{

    public partial class Dashboard : Form
    {
        string path = @"D:\\ChatText.txt";
        public Dashboard()
        {
            InitializeComponent();
        }
        Login log = new Login();
        OleDbConnection conuserinfo = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_userinfo.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextLeightCount.Text = textBox1.TextLength.ToString() + "/230";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            textBox2.Text = "";
            label1.Text = "Welcome " + File.ReadAllText(log.PathData) +" !";
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            else
            {
                textBox2.Text = File.ReadAllText(path);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(!File.Exists(path))
                {
                    textBox2.Text += File.ReadAllText(log.PathData) + ": " + textBox1.Text;
                }
                else
                {
                    textBox2.Text += System.Environment.NewLine + File.ReadAllText(log.PathData) + ": " + textBox1.Text;
                }
                File.WriteAllText(path, textBox2.Text.ToString());
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.Delete(path);
            textBox2.Text = "";
        }
    }
}
