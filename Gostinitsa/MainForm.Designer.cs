﻿namespace Gostinitsa
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Authpanel = new System.Windows.Forms.Panel();
            this.filtrpanel = new System.Windows.Forms.Panel();
            this.infopanel = new System.Windows.Forms.Panel();
            this.authbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LogintextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PasstextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Citycombobox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GostcomboBox = new System.Windows.Forms.ComboBox();
            this.filtrbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Findbutton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Authpanel.SuspendLayout();
            this.filtrpanel.SuspendLayout();
            this.infopanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Authpanel
            // 
            this.Authpanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Authpanel.Controls.Add(this.PasstextBox);
            this.Authpanel.Controls.Add(this.label2);
            this.Authpanel.Controls.Add(this.LogintextBox);
            this.Authpanel.Controls.Add(this.label1);
            this.Authpanel.Controls.Add(this.authbutton);
            this.Authpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Authpanel.Location = new System.Drawing.Point(0, 0);
            this.Authpanel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Authpanel.Name = "Authpanel";
            this.Authpanel.Size = new System.Drawing.Size(1042, 97);
            this.Authpanel.TabIndex = 0;
            // 
            // filtrpanel
            // 
            this.filtrpanel.BackColor = System.Drawing.Color.Lime;
            this.filtrpanel.Controls.Add(this.Findbutton);
            this.filtrpanel.Controls.Add(this.dateTimePicker2);
            this.filtrpanel.Controls.Add(this.dateTimePicker1);
            this.filtrpanel.Controls.Add(this.label8);
            this.filtrpanel.Controls.Add(this.label5);
            this.filtrpanel.Controls.Add(this.filtrbutton);
            this.filtrpanel.Controls.Add(this.GostcomboBox);
            this.filtrpanel.Controls.Add(this.label7);
            this.filtrpanel.Controls.Add(this.label6);
            this.filtrpanel.Controls.Add(this.Citycombobox);
            this.filtrpanel.Controls.Add(this.label3);
            this.filtrpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filtrpanel.Location = new System.Drawing.Point(0, 97);
            this.filtrpanel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.filtrpanel.Name = "filtrpanel";
            this.filtrpanel.Size = new System.Drawing.Size(1042, 416);
            this.filtrpanel.TabIndex = 1;
            this.filtrpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.filtrpanel_Paint);
            // 
            // infopanel
            // 
            this.infopanel.Controls.Add(this.pictureBox2);
            this.infopanel.Controls.Add(this.label4);
            this.infopanel.Controls.Add(this.pictureBox1);
            this.infopanel.Controls.Add(this.label9);
            this.infopanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.infopanel.Location = new System.Drawing.Point(0, 279);
            this.infopanel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.infopanel.Name = "infopanel";
            this.infopanel.Size = new System.Drawing.Size(1042, 425);
            this.infopanel.TabIndex = 2;
            // 
            // authbutton
            // 
            this.authbutton.Location = new System.Drawing.Point(739, 35);
            this.authbutton.Name = "authbutton";
            this.authbutton.Size = new System.Drawing.Size(200, 40);
            this.authbutton.TabIndex = 0;
            this.authbutton.Text = "Войти";
            this.authbutton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // LogintextBox
            // 
            this.LogintextBox.Location = new System.Drawing.Point(123, 23);
            this.LogintextBox.Name = "LogintextBox";
            this.LogintextBox.Size = new System.Drawing.Size(180, 34);
            this.LogintextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // PasstextBox
            // 
            this.PasstextBox.Location = new System.Drawing.Point(446, 23);
            this.PasstextBox.Name = "PasstextBox";
            this.PasstextBox.Size = new System.Drawing.Size(212, 34);
            this.PasstextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Город";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Citycombobox
            // 
            this.Citycombobox.FormattingEnabled = true;
            this.Citycombobox.Items.AddRange(new object[] {
            "Москва ",
            "Нижний Новгород",
            "Казань",
            "Самара",
            "Санкт Петербург"});
            this.Citycombobox.Location = new System.Drawing.Point(156, 67);
            this.Citycombobox.Name = "Citycombobox";
            this.Citycombobox.Size = new System.Drawing.Size(180, 37);
            this.Citycombobox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 29);
            this.label6.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "Гостиница";
            // 
            // GostcomboBox
            // 
            this.GostcomboBox.FormattingEnabled = true;
            this.GostcomboBox.Location = new System.Drawing.Point(156, 118);
            this.GostcomboBox.Name = "GostcomboBox";
            this.GostcomboBox.Size = new System.Drawing.Size(180, 37);
            this.GostcomboBox.TabIndex = 11;
            // 
            // filtrbutton
            // 
            this.filtrbutton.Location = new System.Drawing.Point(3, 0);
            this.filtrbutton.Name = "filtrbutton";
            this.filtrbutton.Size = new System.Drawing.Size(159, 40);
            this.filtrbutton.TabIndex = 12;
            this.filtrbutton.Text = "фильтр";
            this.filtrbutton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Дата заезда";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(372, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 29);
            this.label8.TabIndex = 14;
            this.label8.Text = "Дата выезда";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(533, 65);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(239, 34);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(533, 105);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(239, 34);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // Findbutton
            // 
            this.Findbutton.Location = new System.Drawing.Point(817, 38);
            this.Findbutton.Name = "Findbutton";
            this.Findbutton.Size = new System.Drawing.Size(159, 61);
            this.Findbutton.TabIndex = 17;
            this.Findbutton.Text = "Найти";
            this.Findbutton.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(261, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "Гостиница \"Апельсин\"";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Гостиница \"Виктория\"";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(377, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(287, 182);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1042, 704);
            this.Controls.Add(this.infopanel);
            this.Controls.Add(this.filtrpanel);
            this.Controls.Add(this.Authpanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Authpanel.ResumeLayout(false);
            this.Authpanel.PerformLayout();
            this.filtrpanel.ResumeLayout(false);
            this.filtrpanel.PerformLayout();
            this.infopanel.ResumeLayout(false);
            this.infopanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Authpanel;
        private System.Windows.Forms.Panel filtrpanel;
        private System.Windows.Forms.Panel infopanel;
        private System.Windows.Forms.TextBox PasstextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LogintextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button authbutton;
        private System.Windows.Forms.ComboBox Citycombobox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Findbutton;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button filtrbutton;
        private System.Windows.Forms.ComboBox GostcomboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
    }
}

