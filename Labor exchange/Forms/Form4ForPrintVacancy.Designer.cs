namespace Labor_exchange.Forms
{
    partial class Form4ForPrintVacancy
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
            panel1 = new Panel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(790, 573);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(141, 65);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(632, 23);
            textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(141, 111);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(632, 23);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(141, 166);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(632, 114);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(141, 307);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(632, 23);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(141, 356);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(632, 23);
            textBox5.TabIndex = 8;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(141, 414);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(632, 134);
            textBox6.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 417);
            label7.Name = "label7";
            label7.Size = new Size(111, 15);
            label7.TabIndex = 6;
            label7.Text = "Вимоги до фахівця";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 359);
            label6.Name = "label6";
            label6.Size = new Size(91, 15);
            label6.TabIndex = 5;
            label6.Text = "Житлові умови";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 310);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 4;
            label5.Text = "Оплата";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 169);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 3;
            label4.Text = "Умови праці";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 114);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 2;
            label3.Text = "Посада";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 68);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 1;
            label2.Text = "Фірма";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(291, 17);
            label1.Name = "label1";
            label1.Size = new Size(211, 15);
            label1.TabIndex = 0;
            label1.Text = "Оголошення про пошук працівників";
            // 
            // Form4ForPrintVacancy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 594);
            Controls.Add(panel1);
            Name = "Form4ForPrintVacancy";
            Text = "Оголошення для друку";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
    }
}