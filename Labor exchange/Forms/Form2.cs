using Labor_exchange.Models;
using Labor_exchange.Forms;
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
    public partial class Form2 : Form
    {
        public UnemployedProfile UnemployedProfile; 

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                UnemployedProfile = new UnemployedProfile
                {
                    Name = textBox13.Text,
                    Age = int.TryParse(textBox23.Text, out int age) ? age : 0,
                    Proffession = textBox33.Text,
                    Education = textBox43.Text,
                    LastJobPlace = textBox53.Text,
                    LastJobPosition = textBox63.Text,
                    DismissalReason = textBox73.Text,
                    MaritalStatus = textBox83.Text,
                    Housing = textBox93.Text,
                    Contacts = textBox103.Text,
                    JobExpectations = textBox113.Text
                };
            }
        }
    }
}
