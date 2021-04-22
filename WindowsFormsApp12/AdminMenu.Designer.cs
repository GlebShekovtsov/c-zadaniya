namespace WindowsFormsApp12
{
    partial class AdminMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel_main = new System.Windows.Forms.Panel();
            this.главнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользовательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПользователейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.билетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьБилетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьБилетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокБилетовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главнаяToolStripMenuItem,
            this.пользовательToolStripMenuItem,
            this.билетToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel_main
            // 
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 24);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(800, 426);
            this.panel_main.TabIndex = 2;
            // 
            // главнаяToolStripMenuItem
            // 
            this.главнаяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
            this.главнаяToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.главнаяToolStripMenuItem.Text = "Главная";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // пользовательToolStripMenuItem
            // 
            this.пользовательToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьПользователяToolStripMenuItem,
            this.списокПользователейToolStripMenuItem});
            this.пользовательToolStripMenuItem.Name = "пользовательToolStripMenuItem";
            this.пользовательToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.пользовательToolStripMenuItem.Text = "Пользователь";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить пользователя";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // удалитьПользователяToolStripMenuItem
            // 
            this.удалитьПользователяToolStripMenuItem.Name = "удалитьПользователяToolStripMenuItem";
            this.удалитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.удалитьПользователяToolStripMenuItem.Text = "Удалить пользователя";
            this.удалитьПользователяToolStripMenuItem.Click += new System.EventHandler(this.удалитьПользователяToolStripMenuItem_Click);
            // 
            // списокПользователейToolStripMenuItem
            // 
            this.списокПользователейToolStripMenuItem.Name = "списокПользователейToolStripMenuItem";
            this.списокПользователейToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.списокПользователейToolStripMenuItem.Text = "Список пользователей";
            this.списокПользователейToolStripMenuItem.Click += new System.EventHandler(this.списокПользователейToolStripMenuItem_Click);
            // 
            // билетToolStripMenuItem
            // 
            this.билетToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьБилетToolStripMenuItem,
            this.удалитьБилетToolStripMenuItem,
            this.списокБилетовToolStripMenuItem});
            this.билетToolStripMenuItem.Name = "билетToolStripMenuItem";
            this.билетToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.билетToolStripMenuItem.Text = "Билет";
            // 
            // добавитьБилетToolStripMenuItem
            // 
            this.добавитьБилетToolStripMenuItem.Name = "добавитьБилетToolStripMenuItem";
            this.добавитьБилетToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавитьБилетToolStripMenuItem.Text = "Добавить билет";
            this.добавитьБилетToolStripMenuItem.Click += new System.EventHandler(this.добавитьБилетToolStripMenuItem_Click);
            // 
            // удалитьБилетToolStripMenuItem
            // 
            this.удалитьБилетToolStripMenuItem.Name = "удалитьБилетToolStripMenuItem";
            this.удалитьБилетToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьБилетToolStripMenuItem.Text = "Удалить билет";
            this.удалитьБилетToolStripMenuItem.Click += new System.EventHandler(this.удалитьБилетToolStripMenuItem_Click);
            // 
            // списокБилетовToolStripMenuItem
            // 
            this.списокБилетовToolStripMenuItem.Name = "списокБилетовToolStripMenuItem";
            this.списокБилетовToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.списокБилетовToolStripMenuItem.Text = "Список билетов";
            this.списокБилетовToolStripMenuItem.Click += new System.EventHandler(this.списокБилетовToolStripMenuItem_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminMenu";
            this.Text = "Меню администратора";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem главнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользовательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокПользователейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem билетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьБилетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьБилетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокБилетовToolStripMenuItem;
        private System.Windows.Forms.Panel panel_main;
    }
}