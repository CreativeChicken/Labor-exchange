using Labor_exchange.Models;
using Labor_exchange.Forms;

namespace Labor_exchange
{
    public partial class Form1 : Form
    {
        // Конструктор
        public Form1()
        {
            InitializeComponent();
            JobExchange jobExchangeInstance = new JobExchange();
            jobExchangeInstance.DeserializeData("data.txt");
        }
        // Кнопка пошуку вакансій
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

        // Кнопка пошуку анкет безробітних
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

        // Закриття програми
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Ви хочете зберегти зміни?", "", MessageBoxButtons.YesNoCancel);
            switch (result)
            {
                case DialogResult.Yes:
                    JobExchange jobExchangeInstance = new JobExchange();
                    jobExchangeInstance.SerializeData("data.txt");
                    break;
                case DialogResult.No:
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }

        // Кнопка працевлаштувань(-я)
        private void обратиВакансіюробітникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedItem = listBox1.SelectedItem;

            if (selectedItem is UnemployedProfile unemployedProfile)
            {
                var result = MessageBox.Show(
                    "Ви дійсно хочете обрати цього робітника?",
                    "Підтвердження",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    unemployedProfile.IsArchived = true;
                }
            }
            else if (selectedItem is JobVacancy jobVacancy)
            {
                var result = MessageBox.Show(
                    "Ви дійсно хочете обрати цю вакансію?",
                    "Підтвердження",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    jobVacancy.IsArchived = true;
                }
            }
            else
            {
                MessageBox.Show("Виберіть анкету робітника або вакансію зі списку.");
            }
        }

        // Кнопка відмови від послуг
        private void відмовитисьВідПослугToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedItem = listBox1.SelectedItem;

            if (selectedItem is UnemployedProfile unemployedProfile)
            {
                var result = MessageBox.Show(
                    "Ви дійсно хочете видалити цю анкету?",
                    "Підтвердження",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    JobExchange.RemoveWorksheet(unemployedProfile);
                    JobExchange jobExchangeInstance = new JobExchange();
                    jobExchangeInstance.SerializeData("data.txt");
                }
            }
            else if (selectedItem is JobVacancy jobVacancy)
            {
                var result = MessageBox.Show(
                    "Ви дійсно хочете видалити цю вакансію?",
                    "Підтвердження",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    JobExchange.RemoveWorksheet(jobVacancy);
                    JobExchange jobExchangeInstance = new JobExchange();
                    jobExchangeInstance.SerializeData("data.txt");
                }
            }
            else
            {
                MessageBox.Show("Виберіть анкету робітника або вакансію зі списку.");
            }
        }

        // Кнопка додавання анкети безробітного
        private void анкетаБезробітньогоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using Form2Add form = new();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                JobExchange.AddWorksheet(form.UnemployedProfile);
            }
        }

        // Кнопка додавання вакансії
        private void вакансіяРоботодавцяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using Form3Add form = new();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                JobExchange.AddWorksheet(form.JobVacancy);
            }
        }

        // Кнопка зміни анкети безробітного або вакансії
        private void Змінити_Click(object sender, EventArgs e)
        {
            var selectedItem = listBox1.SelectedItem;

            if (selectedItem is UnemployedProfile profile)
            {
                using Form2Edit form = new(profile);
                form.ShowDialog();
            }
            else if (selectedItem is JobVacancy vacancy)
            {
                using Form3Edit form = new(vacancy);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Виберіть анкету робітника або вакансію зі списку.");
            }
        }

        // Кнопка друку анкети безробітного або вакансії
        private void оголошенняДляДрукуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedItem = listBox1.SelectedItem;

            if (selectedItem is UnemployedProfile profile)
            {
                using Form4ForPrintProfile form = new Form4ForPrintProfile(profile);
                form.ShowDialog();
            }
            else if (selectedItem is JobVacancy vacancy)
            {
                using Form4ForPrintVacancy form = new Form4ForPrintVacancy(vacancy);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Виберіть анкету робітника або вакансію зі списку для друку.");
            }
        }
    }
}
