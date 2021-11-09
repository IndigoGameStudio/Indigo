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
    public partial class Login : Form
    {
        string path = @"D:\\UserName.txt";
        public Login()
        {
            InitializeComponent();
        }
        
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbConnection conuserinfo = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_userinfo.mdb");
        OleDbCommand cmd = new OleDbCommand();
        private void label4_Click(object sender, EventArgs e)
        {
            new Pozadina().Show();
            this.Hide();
        }

        public string PathData { get { return path; } }
        public void LoginSistem()
        {
            if (username.Text != "" && textBox2.Text != "")
            {
                if (username.Text.Length > 2 && textBox2.Text.Length > 2)
                {
                    con.Open();
                    string login = "SELECT * FROM tbl_users WHERE username= '" + username.Text + "' and password= '" + textBox2.Text + "'";
                    cmd = new OleDbCommand(login, con);
                    OleDbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read() == true)
                    {
                        File.WriteAllText(path, username.Text.ToString());
                        new Dashboard().Show();
                        this.Hide();
                        //conuserinfo.Open();
                        //OleDbCommand command = new OleDbCommand();
                        //command.Connection = conuserinfo;
                        //OleDbCommand ac = new OleDbCommand("delete from tlb_userinfo", conuserinfo);
                        //ac.ExecuteNonQuery();
                        //command.CommandText = "insert into tlb_userinfo(username) values('" + username.Text + "')";
                        //conuserinfo.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        username.Text = "";
                        textBox2.Text = "";
                        username.Focus();
                        con.Close();
                    }
                }
                else
                {
                    username.Text = "";
                    textBox2.Text = "";
                    username.Focus();
                    con.Close();
                    MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Username or Password fields are empty.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            LoginSistem();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '•';
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginSistem();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void checkBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void checkBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkBox1.Checked = !checkBox1.Checked;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            File.Create(path);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
