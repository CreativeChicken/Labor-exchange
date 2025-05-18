using Labor_exchange.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Labor_exchange.Forms
{
    public partial class Form3Add : Form
    {
        public JobVacancy JobVacancy;
        // Конструктор
        public Form3Add()
        {
            InitializeComponent();
        }

        // Закриття форми
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                JobVacancy = new JobVacancy
                {
                    Company = textBox14.Text,
                    Position = textBox24.Text,
                    Conditions = textBox34.Text,
                    Salary = textBox44.Text,
                    Housing = textBox54.Text,
                    Requirements = textBox64.Text,
                };
            }
        }

        // Закриття форми з валідацією
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                JobVacancy = new JobVacancy
                {
                    Company = textBox14.Text,
                    Position = textBox24.Text,
                    Conditions = textBox34.Text,
                    Salary = textBox44.Text,
                    Housing = textBox54.Text,
                    Requirements = textBox64.Text,
                };

                // Валидация
                string report = JobVacancy.Validate();
                if (!string.IsNullOrEmpty(report))
                {
                    MessageBox.Show(report);
                    e.Cancel = true;
                }
            }
        }
    }
}
