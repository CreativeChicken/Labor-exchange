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
    // Форма для формування оголошення вакансії
    public partial class FormForPrintVacancy: Form
    {
        public JobVacancy JobVacancy;

        // Конструктор з завчасно заданими даними
        public FormForPrintVacancy(JobVacancy jobVacancy)
        {
            InitializeComponent();

            textBox1.Text = jobVacancy.Company;
            textBox2.Text = jobVacancy.Position;
            textBox3.Text = jobVacancy.Conditions;
            textBox4.Text = jobVacancy.Salary;
            textBox5.Text = jobVacancy.Housing;
            textBox6.Text = jobVacancy.Requirements;
            JobVacancy = jobVacancy;
        }
    }
}
