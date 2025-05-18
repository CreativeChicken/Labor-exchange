using Labor_exchange.Models;
using Labor_exchange.Forms;

namespace Labor_exchange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void findButton1_Click(object sender, EventArgs e)
        {
            var worksheetToFind = new JobVacancy
            {
                Company = textBox1.Text.Trim(),
                Position = textBox2.Text.Trim(),
                Salary = textBox3.Text.Trim(),
                Housing = textBox4.Text.Trim()
            };

            List<Worksheet> result = JobExchange.Find(worksheetToFind);

            nothingFoundLabel.Visible = result.Count == 0;
            listBox1.DataSource = result;
        }

        private void findButton2_Click(object sender, EventArgs e)
        {
            var worksheetToFind = new UnemployedProfile
            {
                Proffession = textBox5.Text.Trim(),
                Education = textBox6.Text.Trim(),
                LastJobPlace = textBox7.Text.Trim(),
                LastJobPosition = textBox8.Text.Trim()
            };

            List<Worksheet> result = JobExchange.Find(worksheetToFind);

            nothingFoundLabel.Visible = result.Count == 0;
            listBox1.DataSource = result;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Ви хочете зберегти зміни?", "", MessageBoxButtons.YesNoCancel);
            switch (result)
            {
                case DialogResult.Yes:
                    break;
                case DialogResult.No:
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }

        private void додатиНовуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using Form2Add form = new();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                JobExchange.AddWorksheet(form.UnemployedProfile);
            }
        }
        private void додатиНовуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using Form3Add form = new();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                JobExchange.AddWorksheet(form.JobVacancy);
            }
        }

        private void змінитиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UnemployedProfile unemployedProfile = listBox1.SelectedItem as UnemployedProfile;
            if (unemployedProfile == null)
            {
                MessageBox.Show("Виберіть анкету із списку робітників");
            }
            else
            {
                using Form2Edit form = new(unemployedProfile);
                form.ShowDialog();
            }
        }

        private void змінитиToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            JobVacancy jobVacancy = listBox1.SelectedItem as JobVacancy;
            if (jobVacancy == null)
            {
                MessageBox.Show("Виберіть вакансію із списку вакансій");
            }
            else
            {
                using Form3Edit form = new(jobVacancy);
                form.ShowDialog();
            }
        }
    }
}
