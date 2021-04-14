namespace studentApp
{
    partial class Form_main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.главнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокСтудентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСтудентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПреподавателяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПреподавателейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_mane = new System.Windows.Forms.Panel();
            this.администраторыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьСписокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьАдминистратораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главнаяToolStripMenuItem,
            this.студентыToolStripMenuItem,
            this.пToolStripMenuItem,
            this.администраторыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(918, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // студентыToolStripMenuItem
            // 
            this.студентыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокСтудентовToolStripMenuItem,
            this.добавитьСтудентаToolStripMenuItem});
            this.студентыToolStripMenuItem.Name = "студентыToolStripMenuItem";
            this.студентыToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.студентыToolStripMenuItem.Text = "Студенты";
            // 
            // списокСтудентовToolStripMenuItem
            // 
            this.списокСтудентовToolStripMenuItem.Name = "списокСтудентовToolStripMenuItem";
            this.списокСтудентовToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.списокСтудентовToolStripMenuItem.Text = "Список студентов";
            this.списокСтудентовToolStripMenuItem.Click += new System.EventHandler(this.списокСтудентовToolStripMenuItem_Click);
            // 
            // добавитьСтудентаToolStripMenuItem
            // 
            this.добавитьСтудентаToolStripMenuItem.Name = "добавитьСтудентаToolStripMenuItem";
            this.добавитьСтудентаToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.добавитьСтудентаToolStripMenuItem.Text = "Добавить студента";
            this.добавитьСтудентаToolStripMenuItem.Click += new System.EventHandler(this.добавитьСтудентаToolStripMenuItem_Click);
            // 
            // пToolStripMenuItem
            // 
            this.пToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьПреподавателяToolStripMenuItem,
            this.списокПреподавателейToolStripMenuItem});
            this.пToolStripMenuItem.Name = "пToolStripMenuItem";
            this.пToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.пToolStripMenuItem.Text = "Преподаватели";
            // 
            // добавитьПреподавателяToolStripMenuItem
            // 
            this.добавитьПреподавателяToolStripMenuItem.Name = "добавитьПреподавателяToolStripMenuItem";
            this.добавитьПреподавателяToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.добавитьПреподавателяToolStripMenuItem.Text = "Добавить преподавателя";
            this.добавитьПреподавателяToolStripMenuItem.Click += new System.EventHandler(this.добавитьПреподавателяToolStripMenuItem_Click);
            // 
            // списокПреподавателейToolStripMenuItem
            // 
            this.списокПреподавателейToolStripMenuItem.Name = "списокПреподавателейToolStripMenuItem";
            this.списокПреподавателейToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.списокПреподавателейToolStripMenuItem.Text = "Список преподавателей";
            this.списокПреподавателейToolStripMenuItem.Click += new System.EventHandler(this.списокПреподавателейToolStripMenuItem_Click);
            // 
            // panel_mane
            // 
            this.panel_mane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_mane.Location = new System.Drawing.Point(0, 24);
            this.panel_mane.Margin = new System.Windows.Forms.Padding(2);
            this.panel_mane.Name = "panel_mane";
            this.panel_mane.Size = new System.Drawing.Size(918, 529);
            this.panel_mane.TabIndex = 1;
            // 
            // администраторыToolStripMenuItem
            // 
            this.администраторыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотретьСписокToolStripMenuItem,
            this.добавитьАдминистратораToolStripMenuItem});
            this.администраторыToolStripMenuItem.Name = "администраторыToolStripMenuItem";
            this.администраторыToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.администраторыToolStripMenuItem.Text = "Администраторы";
            // 
            // просмотретьСписокToolStripMenuItem
            // 
            this.просмотретьСписокToolStripMenuItem.Name = "просмотретьСписокToolStripMenuItem";
            this.просмотретьСписокToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.просмотретьСписокToolStripMenuItem.Text = "Просмотреть список";
            this.просмотретьСписокToolStripMenuItem.Click += new System.EventHandler(this.просмотретьСписокToolStripMenuItem_Click);
            // 
            // добавитьАдминистратораToolStripMenuItem
            // 
            this.добавитьАдминистратораToolStripMenuItem.Name = "добавитьАдминистратораToolStripMenuItem";
            this.добавитьАдминистратораToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.добавитьАдминистратораToolStripMenuItem.Text = "Добавить администратора";
            this.добавитьАдминистратораToolStripMenuItem.Click += new System.EventHandler(this.добавитьАдминистратораToolStripMenuItem_Click);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 553);
            this.Controls.Add(this.panel_mane);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(934, 592);
            this.MinimumSize = new System.Drawing.Size(934, 592);
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет студентов";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem главнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокСтудентовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьСтудентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьПреподавателяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокПреподавателейToolStripMenuItem;
        private System.Windows.Forms.Panel panel_mane;
        private System.Windows.Forms.ToolStripMenuItem администраторыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотретьСписокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьАдминистратораToolStripMenuItem;
    }
}

