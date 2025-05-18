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
    public partial class Form2Edit : Form
    {
        public UnemployedProfile UnemployedProfile;

        public Form2Edit(UnemployedProfile unemployedProfile)
        {
            InitializeComponent();

            textBoxEdit13.Text = unemployedProfile.Name;
            textBoxEdit23.Text = unemployedProfile.Age.ToString();
            textBoxEdit33.Text = unemployedProfile.Proffession;
            textBoxEdit43.Text = unemployedProfile.Education;
            textBoxEdit53.Text = unemployedProfile.LastJobPlace;
            textBoxEdit63.Text = unemployedProfile.LastJobPosition;
            textBoxEdit73.Text = unemployedProfile.DismissalReason;
            textBoxEdit83.Text = unemployedProfile.MaritalStatus;
            textBoxEdit93.Text = unemployedProfile.Housing;
            textBoxEdit103.Text = unemployedProfile.Contacts;
            textBoxEdit113.Text = unemployedProfile.JobExpectations;
            UnemployedProfile = unemployedProfile;
        }

        private void Form2Edit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                UnemployedProfile.Name = textBoxEdit13.Text;
                UnemployedProfile.Age = int.Parse(textBoxEdit23.Text);
                UnemployedProfile.Proffession = textBoxEdit33.Text;
                UnemployedProfile.Education = textBoxEdit43.Text;
                UnemployedProfile.LastJobPlace = textBoxEdit53.Text;
                UnemployedProfile.LastJobPosition = textBoxEdit63.Text;
                UnemployedProfile.DismissalReason = textBoxEdit73.Text;
                UnemployedProfile.MaritalStatus = textBoxEdit83.Text;
                UnemployedProfile.Housing = textBoxEdit93.Text;
                UnemployedProfile.Contacts = textBoxEdit103.Text;
                UnemployedProfile.JobExpectations = textBoxEdit113.Text;
            }
        }
    }
}
