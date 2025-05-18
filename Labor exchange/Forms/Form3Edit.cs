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
    public partial class Form3Edit : Form
    {
        public JobVacancy JobVacancy;

        public Form3Edit(JobVacancy jobVacancy)
        {
            InitializeComponent();

            textBoxEdit14.Text = jobVacancy.Company;
            textBoxEdit24.Text = jobVacancy.Position;
            textBoxEdit34.Text = jobVacancy.Conditions;
            textBoxEdit44.Text = jobVacancy.Salary;
            textBoxEdit54.Text = jobVacancy.Housing;
            textBoxEdit64.Text = jobVacancy.Requirements;
            JobVacancy = jobVacancy;
        }

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
            }
        }
    }
}
