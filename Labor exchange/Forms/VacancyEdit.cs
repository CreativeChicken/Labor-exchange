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

namespace Labor_exchange.Forms
{
    // Форма для редагування вакансії
    public partial class VacancyEdit : Form
    {
        public JobVacancy JobVacancy;

        // Конструктор з завчасно заданими даними та прив'язка клавіш
        public VacancyEdit(JobVacancy jobVacancy)
        {
            InitializeComponent();

            textBoxEdit14.Text = jobVacancy.Company;
            textBoxEdit24.Text = jobVacancy.Position;
            textBoxEdit34.Text = jobVacancy.Conditions;
            textBoxEdit44.Text = jobVacancy.Salary;
            textBoxEdit54.Text = jobVacancy.Housing;
            textBoxEdit64.Text = jobVacancy.Requirements;
            JobVacancy = jobVacancy;

            this.KeyPreview = true;
            this.KeyDown += Form3Edit_KeyDown;
        }

        // Закриттям форми з валідацією
        private void Form3Edit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                JobVacancy.Company = textBoxEdit14.Text;
                JobVacancy.Position = textBoxEdit24.Text;
                JobVacancy.Conditions = textBoxEdit34.Text;
                JobVacancy.Salary = textBoxEdit44.Text;
                JobVacancy.Housing = textBoxEdit54.Text;
                JobVacancy.Requirements = textBoxEdit64.Text;

                // валідація
                string report = JobVacancy.Validate();
                if (report != "")
                {
                    MessageBox.Show(report);
                    e.Cancel = true;
                }
            }
        }

        // Обробка натискання клавіш Enter та Escape
        private void Form3Edit_KeyDown(object sender, KeyEventArgs e)
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
