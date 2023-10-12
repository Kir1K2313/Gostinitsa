namespace Gostinitsa
{
    partial class RoomForm
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
            this.Infopanel = new System.Windows.Forms.Panel();
            this.RoomtextBox = new System.Windows.Forms.TextBox();
            this.Roomlabel = new System.Windows.Forms.Label();
            this.RoompictureBox = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Infopanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoompictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Infopanel
            // 
            this.Infopanel.Controls.Add(this.RoomtextBox);
            this.Infopanel.Controls.Add(this.Roomlabel);
            this.Infopanel.Controls.Add(this.RoompictureBox);
            this.Infopanel.Controls.Add(this.flowLayoutPanel1);
            this.Infopanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Infopanel.Location = new System.Drawing.Point(0, 0);
            this.Infopanel.Name = "Infopanel";
            this.Infopanel.Size = new System.Drawing.Size(1209, 237);
            this.Infopanel.TabIndex = 0;
            // 
            // RoomtextBox
            // 
            this.RoomtextBox.Location = new System.Drawing.Point(428, 63);
            this.RoomtextBox.Multiline = true;
            this.RoomtextBox.Name = "RoomtextBox";
            this.RoomtextBox.Size = new System.Drawing.Size(713, 152);
            this.RoomtextBox.TabIndex = 3;
            // 
            // Roomlabel
            // 
            this.Roomlabel.AutoSize = true;
            this.Roomlabel.Location = new System.Drawing.Point(423, 15);
            this.Roomlabel.Name = "Roomlabel";
            this.Roomlabel.Size = new System.Drawing.Size(79, 29);
            this.Roomlabel.TabIndex = 2;
            this.Roomlabel.Text = "label1";
            // 
            // RoompictureBox
            // 
            this.RoompictureBox.Location = new System.Drawing.Point(26, 12);
            this.RoompictureBox.Name = "RoompictureBox";
            this.RoompictureBox.Size = new System.Drawing.Size(347, 203);
            this.RoompictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RoompictureBox.TabIndex = 1;
            this.RoompictureBox.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 94);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(20, 8);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 302);
            this.panel1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(191, 114);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(251, 34);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(191, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(251, 34);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата выезда";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата заезда";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 478);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Infopanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            this.Infopanel.ResumeLayout(false);
            this.Infopanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoompictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Infopanel;
        private System.Windows.Forms.TextBox RoomtextBox;
        private System.Windows.Forms.Label Roomlabel;
        private System.Windows.Forms.PictureBox RoompictureBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}