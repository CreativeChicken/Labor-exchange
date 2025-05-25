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
    public partial class Form2Add : Form
    {
        public UnemployedProfile UnemployedProfile;

        // Конструктор та прив'язка клавіш
        public Form2Add()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.KeyDown += Form2Add_KeyDown;
        }

        /// Створення UnemployedProfile з введених даних
        private UnemployedProfile CreateUnemployedProfileFromInputs()
        {
            return new UnemployedProfile
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

        // Закриття форми
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                UnemployedProfile = CreateUnemployedProfileFromInputs();
            }
        }

        // Закриття форми з валідацією
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                UnemployedProfile = CreateUnemployedProfileFromInputs();

                // Валидация
                string report = UnemployedProfile.Validate();
                if (report != "")
                {
                    MessageBox.Show(report);
                    e.Cancel = true;
                }
            }
        }

        // Обробка натискання клавіш Enter та Escape
        private void Form2Add_KeyDown(object sender, KeyEventArgs e)
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
