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
    // Форма для додавання нової вакансії
    public partial class VacancyAdd : Form
    {
        public JobVacancy JobVacancy;
        // Конструктор та прив'язка клавіш
        public VacancyAdd()
        {
            InitializeComponent();


            this.KeyPreview = true;
            this.KeyDown += Form3Add_KeyDown;
        }

        // Створення об'єкта JobVacancy з введених даних
        private JobVacancy CreateJobVacancyFromInputs()
        {
            return new JobVacancy
            {
                Company = textBox14.Text,
                Position = textBox24.Text,
                Conditions = textBox34.Text,
                Salary = textBox44.Text,
                Housing = textBox54.Text,
                Requirements = textBox64.Text,
            };
        }

        // Закриття форми
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                JobVacancy = CreateJobVacancyFromInputs();
            }
        }

        // Закриття форми з валідацією
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                JobVacancy = CreateJobVacancyFromInputs();

                // Валидация
                string report = JobVacancy.Validate();
                if (!string.IsNullOrEmpty(report))
                {
                    MessageBox.Show(report);
                    e.Cancel = true;
                }
            }
        }

        // Обробка натискання клавіш Enter та Escape
        private void Form3Add_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
                e.Handled = true;
            }
        }
    }
}
