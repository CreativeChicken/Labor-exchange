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
    public partial class Form4ForPrintVacancy: Form
    {
        public JobVacancy JobVacancy;

        // Конструктор з завчасно заданими даними
        public Form4ForPrintVacancy(JobVacancy jobVacancy)
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
