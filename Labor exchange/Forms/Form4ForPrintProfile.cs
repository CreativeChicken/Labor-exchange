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
    public partial class Form4ForPrintProfile : Form
    {
        public UnemployedProfile UnemployedProfile;

        // Конструктор з завчасно заданими даними
        public Form4ForPrintProfile(UnemployedProfile unemployedProfile)
        {
            InitializeComponent();

            textBox1.Text = unemployedProfile.Name;
            textBox2.Text = unemployedProfile.Age.ToString();
            textBox3.Text = unemployedProfile.Proffession;
            textBox4.Text = unemployedProfile.Education;
            textBox5.Text = unemployedProfile.LastJobPlace;
            textBox6.Text = unemployedProfile.LastJobPosition;
            textBox7.Text = unemployedProfile.DismissalReason;
            textBox8.Text = unemployedProfile.MaritalStatus;
            textBox9.Text = unemployedProfile.Housing;
            textBox10.Text = unemployedProfile.Contacts;
            textBox11.Text = unemployedProfile.JobExpectations;
            UnemployedProfile = unemployedProfile;
        }
    }
}
