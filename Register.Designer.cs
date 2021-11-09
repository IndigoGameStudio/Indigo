
namespace Indigo
{
    partial class Pozadina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pozadina));
            this.Naslov = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserNameRegister = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Pass1Register = new System.Windows.Forms.TextBox();
            this.Pass2Register = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Naslov
            // 
            this.Naslov.AutoSize = true;
            this.Naslov.BackColor = System.Drawing.Color.Transparent;
            this.Naslov.Font = new System.Drawing.Font("Silver Charm Duo", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Naslov.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Naslov.Location = new System.Drawing.Point(100, 1);
            this.Naslov.Name = "Naslov";
            this.Naslov.Size = new System.Drawing.Size(193, 75);
            this.Naslov.TabIndex = 0;
            this.Naslov.Text = "INDIGO APP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Silver Charm Duo", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(24, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserNameRegister
            // 
            this.UserNameRegister.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameRegister.ForeColor = System.Drawing.SystemColors.WindowText;
            this.UserNameRegister.Location = new System.Drawing.Point(32, 155);
            this.UserNameRegister.MaxLength = 16;
            this.UserNameRegister.Name = "UserNameRegister";
            this.UserNameRegister.Size = new System.Drawing.Size(247, 30);
            this.UserNameRegister.TabIndex = 2;
            this.UserNameRegister.TextChanged += new System.EventHandler(this.UserNameRegister_TextChanged);
            this.UserNameRegister.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserNameRegister_KeyDown_1);
            this.UserNameRegister.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserNameRegister_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Silver Charm Duo", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(24, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Silver Charm Duo", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(24, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 43);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirm password";
            // 
            // Pass1Register
            // 
            this.Pass1Register.Font = new System.Drawing.Font("Ink Free", 10.8F);
            this.Pass1Register.Location = new System.Drawing.Point(32, 228);
            this.Pass1Register.MaxLength = 16;
            this.Pass1Register.Name = "Pass1Register";
            this.Pass1Register.PasswordChar = '•';
            this.Pass1Register.Size = new System.Drawing.Size(247, 30);
            this.Pass1Register.TabIndex = 5;
            this.Pass1Register.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pass1Register_KeyDown);
            // 
            // Pass2Register
            // 
            this.Pass2Register.Font = new System.Drawing.Font("Ink Free", 10.8F);
            this.Pass2Register.Location = new System.Drawing.Point(32, 305);
            this.Pass2Register.MaxLength = 16;
            this.Pass2Register.Name = "Pass2Register";
            this.Pass2Register.PasswordChar = '•';
            this.Pass2Register.Size = new System.Drawing.Size(247, 30);
            this.Pass2Register.TabIndex = 6;
            this.Pass2Register.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pass2Register_KeyDown);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Silver Charm Duo", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(32, 338);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 32);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Show password";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkBox1_KeyDown);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Silver Charm Duo", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(99, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Silver Charm Duo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(123, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Already have an account";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Pozadina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Pass2Register);
            this.Controls.Add(this.Pass1Register);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserNameRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Naslov);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pozadina";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Indigo";
            this.Load += new System.EventHandler(this.Pozadina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Naslov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserNameRegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Pass1Register;
        private System.Windows.Forms.TextBox Pass2Register;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}

