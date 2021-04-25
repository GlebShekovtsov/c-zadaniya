
namespace AirLinesBD
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Логин";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 55);
            this.button1.TabIndex = 7;
            this.button1.Text = "ВОЙТИ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(85, 238);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(196, 20);
            this.textBox_password.TabIndex = 6;
            this.textBox_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_password_KeyDown_1);
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(85, 140);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(196, 20);
            this.textBox_login.TabIndex = 5;
            this.textBox_login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_login_KeyDown_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 434);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_login;
    }
}

