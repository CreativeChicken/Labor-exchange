namespace Labor_exchange
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
            menuStrip1 = new MenuStrip();
            оголошенняДляДрукуToolStripMenuItem = new ToolStripMenuItem();
            змінитиToolStripMenuItem = new ToolStripMenuItem();
            анкетаБезробітньогоїToolStripMenuItem = new ToolStripMenuItem();
            додатиНовуToolStripMenuItem = new ToolStripMenuItem();
            змінитиToolStripMenuItem1 = new ToolStripMenuItem();
            анкетаРоботодавцяToolStripMenuItem = new ToolStripMenuItem();
            додатиНовуToolStripMenuItem1 = new ToolStripMenuItem();
            listBox1 = new ListBox();
            worksheetBindingSource = new BindingSource(components);
            panel1 = new Panel();
            findButton1 = new Button();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            findButton2 = new Button();
            textBox6 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox5 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            nothingFoundLabel = new Label();
            змінитиToolStripMenuItem2 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)worksheetBindingSource).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { оголошенняДляДрукуToolStripMenuItem, змінитиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1924, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // оголошенняДляДрукуToolStripMenuItem
            // 
            оголошенняДляДрукуToolStripMenuItem.Name = "оголошенняДляДрукуToolStripMenuItem";
            оголошенняДляДрукуToolStripMenuItem.Size = new Size(216, 29);
            оголошенняДляДрукуToolStripMenuItem.Text = "Оголошення для друку";
            // 
            // змінитиToolStripMenuItem
            // 
            змінитиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { анкетаБезробітньогоїToolStripMenuItem, анкетаРоботодавцяToolStripMenuItem });
            змінитиToolStripMenuItem.Name = "змінитиToolStripMenuItem";
            змінитиToolStripMenuItem.Size = new Size(90, 29);
            змінитиToolStripMenuItem.Text = "Змінити";
            // 
            // анкетаБезробітньогоїToolStripMenuItem
            // 
            анкетаБезробітньогоїToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { додатиНовуToolStripMenuItem, змінитиToolStripMenuItem1 });
            анкетаБезробітньогоїToolStripMenuItem.Name = "анкетаБезробітньогоїToolStripMenuItem";
            анкетаБезробітньогоїToolStripMenuItem.Size = new Size(291, 30);
            анкетаБезробітньогоїToolStripMenuItem.Text = "Анкета безробітнього(ї)";
            // 
            // додатиНовуToolStripMenuItem
            // 
            додатиНовуToolStripMenuItem.Name = "додатиНовуToolStripMenuItem";
            додатиНовуToolStripMenuItem.Size = new Size(202, 30);
            додатиНовуToolStripMenuItem.Text = "Додати нову";
            додатиНовуToolStripMenuItem.Click += додатиНовуToolStripMenuItem_Click;
            // 
            // змінитиToolStripMenuItem1
            // 
            змінитиToolStripMenuItem1.Name = "змінитиToolStripMenuItem1";
            змінитиToolStripMenuItem1.Size = new Size(202, 30);
            змінитиToolStripMenuItem1.Text = "Змінити";
            змінитиToolStripMenuItem1.Click += змінитиToolStripMenuItem1_Click;
            // 
            // анкетаРоботодавцяToolStripMenuItem
            // 
            анкетаРоботодавцяToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { додатиНовуToolStripMenuItem1, змінитиToolStripMenuItem2 });
            анкетаРоботодавцяToolStripMenuItem.Name = "анкетаРоботодавцяToolStripMenuItem";
            анкетаРоботодавцяToolStripMenuItem.Size = new Size(291, 30);
            анкетаРоботодавцяToolStripMenuItem.Text = "Анкета роботодавця";
            // 
            // додатиНовуToolStripMenuItem1
            // 
            додатиНовуToolStripMenuItem1.Name = "додатиНовуToolStripMenuItem1";
            додатиНовуToolStripMenuItem1.Size = new Size(224, 30);
            додатиНовуToolStripMenuItem1.Text = "Додати нову";
            додатиНовуToolStripMenuItem1.Click += додатиНовуToolStripMenuItem1_Click;
            // 
            // listBox1
            // 
            listBox1.DataSource = worksheetBindingSource;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(519, 40);
            listBox1.Margin = new Padding(4, 5, 4, 5);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1371, 1004);
            listBox1.TabIndex = 1;
            // 
            // worksheetBindingSource
            // 
            worksheetBindingSource.DataSource = typeof(Models.Worksheet);
            // 
            // panel1
            // 
            panel1.Controls.Add(findButton1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(7, 40);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(479, 422);
            panel1.TabIndex = 2;
            // 
            // findButton1
            // 
            findButton1.Location = new Point(121, 355);
            findButton1.Margin = new Padding(4, 5, 4, 5);
            findButton1.Name = "findButton1";
            findButton1.Size = new Size(223, 53);
            findButton1.TabIndex = 9;
            findButton1.Text = "Пошук";
            findButton1.UseVisualStyleBackColor = true;
            findButton1.Click += findButton1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(97, 150);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(331, 31);
            textBox2.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(97, 292);
            textBox4.Margin = new Padding(4, 5, 4, 5);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(331, 31);
            textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(97, 222);
            textBox3.Margin = new Padding(4, 5, 4, 5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(331, 31);
            textBox3.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(97, 75);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(331, 31);
            textBox1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 297);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 25);
            label5.TabIndex = 4;
            label5.Text = "Житло";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 227);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 3;
            label4.Text = "Оплата";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 150);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 2;
            label3.Text = "Посада";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 80);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 1;
            label2.Text = "Фірма";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 17);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 0;
            label1.Text = "Пошук вакансій";
            // 
            // panel2
            // 
            panel2.Controls.Add(findButton2);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(textBox8);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Location = new Point(7, 482);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(479, 562);
            panel2.TabIndex = 3;
            // 
            // findButton2
            // 
            findButton2.Location = new Point(137, 485);
            findButton2.Margin = new Padding(4, 5, 4, 5);
            findButton2.Name = "findButton2";
            findButton2.Size = new Size(223, 53);
            findButton2.TabIndex = 9;
            findButton2.Text = "Пошук";
            findButton2.UseVisualStyleBackColor = true;
            findButton2.Click += findButton2_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(97, 150);
            textBox6.Margin = new Padding(4, 5, 4, 5);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(331, 31);
            textBox6.TabIndex = 8;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(97, 415);
            textBox8.Margin = new Padding(4, 5, 4, 5);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(331, 31);
            textBox8.TabIndex = 7;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(97, 283);
            textBox7.Margin = new Padding(4, 5, 4, 5);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(331, 31);
            textBox7.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(97, 75);
            textBox5.Margin = new Padding(4, 5, 4, 5);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(331, 31);
            textBox5.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 355);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(331, 25);
            label6.TabIndex = 4;
            label6.Text = "Посада останнього працевлаштування";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 227);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(319, 25);
            label7.TabIndex = 3;
            label7.Text = "Місце останнього працевлаштування";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 150);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(64, 25);
            label8.TabIndex = 2;
            label8.Text = "Освіта";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 80);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(89, 25);
            label9.TabIndex = 1;
            label9.Text = "Професія";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(169, 17);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(159, 25);
            label10.TabIndex = 0;
            label10.Text = "Пошук робітників";
            // 
            // nothingFoundLabel
            // 
            nothingFoundLabel.AutoSize = true;
            nothingFoundLabel.Location = new Point(1118, 72);
            nothingFoundLabel.Margin = new Padding(4, 0, 4, 0);
            nothingFoundLabel.Name = "nothingFoundLabel";
            nothingFoundLabel.Size = new Size(174, 25);
            nothingFoundLabel.TabIndex = 4;
            nothingFoundLabel.Text = "Нічого не знайдено";
            // 
            // змінитиToolStripMenuItem2
            // 
            змінитиToolStripMenuItem2.Name = "змінитиToolStripMenuItem2";
            змінитиToolStripMenuItem2.Size = new Size(224, 30);
            змінитиToolStripMenuItem2.Text = "Змінити";
            змінитиToolStripMenuItem2.Click += змінитиToolStripMenuItem2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(nothingFoundLabel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(listBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Список вакансій";
            FormClosing += Form1_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)worksheetBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ListBox listBox1;
        private Panel panel1;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox1;
        private ToolStripMenuItem оголошенняДляДрукуToolStripMenuItem;
        private Button findButton1;
        private Panel panel2;
        private Button findButton2;
        private TextBox textBox6;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label nothingFoundLabel;
        private ToolStripMenuItem змінитиToolStripMenuItem;
        private ToolStripMenuItem анкетаБезробітньогоїToolStripMenuItem;
        private ToolStripMenuItem додатиНовуToolStripMenuItem;
        private ToolStripMenuItem анкетаРоботодавцяToolStripMenuItem;
        private ToolStripMenuItem додатиНовуToolStripMenuItem1;
        private BindingSource worksheetBindingSource;
        private ToolStripMenuItem змінитиToolStripMenuItem1;
        private ToolStripMenuItem змінитиToolStripMenuItem2;
    }
}
