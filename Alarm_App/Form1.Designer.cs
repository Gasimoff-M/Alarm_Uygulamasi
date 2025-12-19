namespace Alarm_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            label1 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(52, 77);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 34);
            label2.TabIndex = 1;
            label2.Text = "00 : 00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 11);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 35);
            label1.TabIndex = 0;
            label1.Text = "Yerel Saat";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(447, 112);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(110, 41);
            comboBox2.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(323, 112);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(93, 41);
            comboBox1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(447, 65);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(110, 35);
            label4.TabIndex = 9;
            label4.Text = "Dakika";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(10, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(251, 221);
            panel1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(335, 65);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 35);
            label3.TabIndex = 7;
            label3.Text = "Saat";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(612, 249);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(label3);
            Font = new Font("Constantia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Label label1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label4;
        private Panel panel1;
        private Label label3;
    }
}
