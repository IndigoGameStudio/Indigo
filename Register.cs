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

namespace Indigo
{
    public partial class Pozadina : Form
    {
        public Pozadina()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Pozadina_Load(object sender, EventArgs e)
        {

        }

        private void RegisterSistem()
        {
            if (Pass1Register.Text.Length > 2 && Pass2Register.Text.Length > 2 && UserNameRegister.Text.Length > 2)
            {
                if (UserNameRegister.Text == "" || Pass1Register.Text == "" || Pass2Register.Text == "")
                {
                    MessageBox.Show("Username or Password fields are empty.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (UserNameRegister.Text == Pass1Register.Text)
                {
                    MessageBox.Show("Username and Password cannot be the same.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (Pass1Register.Text == Pass2Register.Text)
                {
                    con.Open();
                    string login = "SELECT * FROM tbl_users WHERE username= '" + UserNameRegister.Text + "' and password= '" + Pass1Register.Text + "'";
                    cmd = new OleDbCommand(login, con);
                    OleDbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read() == false)
                    {
                        con.Close();
                        con.Open();
                        string register = "INSERT INTO tbl_users VALUES ('" + UserNameRegister.Text + "','" + Pass1Register.Text + "','" + Pass2Register.Text + "')";
                        cmd = new OleDbCommand(register, con);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        UserNameRegister.Text = "";
                        Pass1Register.Text = "";
                        Pass2Register.Text = "";
                        new Login().Show();
                        this.Hide();
                        MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        con.Close();
                        MessageBox.Show("The username you entered already exists.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Passwords does not match.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Pass1Register.Text = "";
                    Pass2Register.Text = "";
                    Pass1Register.Focus();
                }
            }
            else
            {
                MessageBox.Show("Password and username must be minimum 3 characters long.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            RegisterSistem();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Pass1Register.PasswordChar = '\0';
                Pass2Register.PasswordChar = '\0';
            }
            else
            {
                Pass1Register.PasswordChar = '•';
                Pass2Register.PasswordChar = '•';
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }


        private void UserNameRegister_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserNameRegister_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                RegisterSistem();
            } 
        }

        private void UserNameRegister_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Pass1Register.Focus();
            }
        }

        private void Pass1Register_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Pass2Register.Focus();
            }
        }

        private void Pass2Register_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RegisterSistem();

            }
        }

        private void checkBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkBox1.Checked = !checkBox1.Checked;
            }
        }

        private void UserNameRegister_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
