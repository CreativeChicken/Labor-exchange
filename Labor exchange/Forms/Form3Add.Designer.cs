namespace Labor_exchange.Forms
{
    partial class Form3Add
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
            textBox64 = new TextBox();
            textBox54 = new TextBox();
            textBox44 = new TextBox();
            textBox34 = new TextBox();
            textBox24 = new TextBox();
            textBox14 = new TextBox();
            label64 = new Label();
            label54 = new Label();
            label44 = new Label();
            label34 = new Label();
            label24 = new Label();
            label14 = new Label();
            button14 = new Button();
            button24 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox64);
            panel1.Controls.Add(textBox54);
            panel1.Controls.Add(textBox44);
            panel1.Controls.Add(textBox34);
            panel1.Controls.Add(textBox24);
            panel1.Controls.Add(textBox14);
            panel1.Controls.Add(label64);
            panel1.Controls.Add(label54);
            panel1.Controls.Add(label44);
            panel1.Controls.Add(label34);
            panel1.Controls.Add(label24);
            panel1.Controls.Add(label14);
            panel1.Location = new Point(46, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(763, 235);
            panel1.TabIndex = 0;
            // 
            // textBox64
            // 
            textBox64.Location = new Point(569, 142);
            textBox64.Name = "textBox64";
            textBox64.Size = new Size(138, 31);
            textBox64.TabIndex = 11;
            // 
            // textBox54
            // 
            textBox54.Location = new Point(569, 81);
            textBox54.Name = "textBox54";
            textBox54.Size = new Size(138, 31);
            textBox54.TabIndex = 10;
            // 
            // textBox44
            // 
            textBox44.Location = new Point(569, 28);
            textBox44.Name = "textBox44";
            textBox44.Size = new Size(138, 31);
            textBox44.TabIndex = 9;
            // 
            // textBox34
            // 
            textBox34.Location = new Point(158, 148);
            textBox34.Name = "textBox34";
            textBox34.Size = new Size(138, 31);
            textBox34.TabIndex = 8;
            // 
            // textBox24
            // 
            textBox24.Location = new Point(158, 84);
            textBox24.Name = "textBox24";
            textBox24.Size = new Size(138, 31);
            textBox24.TabIndex = 7;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(158, 28);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(138, 31);
            textBox14.TabIndex = 6;
            // 
            // label64
            // 
            label64.AutoSize = true;
            label64.Location = new Point(370, 148);
            label64.Name = "label64";
            label64.Size = new Size(167, 25);
            label64.TabIndex = 5;
            label64.Text = "Вимоги до фахівця";
            // 
            // label54
            // 
            label54.AutoSize = true;
            label54.Location = new Point(370, 84);
            label54.Name = "label54";
            label54.Size = new Size(137, 25);
            label54.TabIndex = 4;
            label54.Text = "Житлові умови";
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Location = new Point(370, 31);
            label44.Name = "label44";
            label44.Size = new Size(142, 25);
            label44.TabIndex = 3;
            label44.Text = "Заробітня плата";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(37, 148);
            label34.Name = "label34";
            label34.Size = new Size(116, 25);
            label34.TabIndex = 2;
            label34.Text = "Умови праці";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(37, 84);
            label24.Name = "label24";
            label24.Size = new Size(72, 25);
            label24.TabIndex = 1;
            label24.Text = "Посада";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(37, 31);
            label14.Name = "label14";
            label14.Size = new Size(62, 25);
            label14.TabIndex = 0;
            label14.Text = "Фірма";
            // 
            // button14
            // 
            button14.DialogResult = DialogResult.OK;
            button14.Location = new Point(224, 314);
            button14.Name = "button14";
            button14.Size = new Size(138, 51);
            button14.TabIndex = 1;
            button14.Text = "Зберегти";
            button14.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            button24.DialogResult = DialogResult.Cancel;
            button24.Location = new Point(486, 314);
            button24.Name = "button24";
            button24.Size = new Size(138, 51);
            button24.TabIndex = 2;
            button24.Text = "Відмінити";
            button24.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 402);
            Controls.Add(button24);
            Controls.Add(button14);
            Controls.Add(panel1);
            Name = "Form3";
            Text = "Додавання вакансії";
            FormClosed += Form3_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox64;
        private TextBox textBox54;
        private TextBox textBox44;
        private TextBox textBox34;
        private TextBox textBox24;
        private TextBox textBox14;
        private Label label64;
        private Label label54;
        private Label label44;
        private Label label34;
        private Label label24;
        private Label label14;
        private Button button14;
        private Button button24;
    }
}