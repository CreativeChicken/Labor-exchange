using Labor_exchange.Models;
using Labor_exchange.Forms;

namespace Labor_exchange
{
    // Головна форма програми
    public partial class MainForm : Form
    {
        private string _originalData;
        // Конструктор
        public MainForm()
        {
            InitializeComponent();
            JobExchange jobExchangeInstance = new JobExchange();
            jobExchangeInstance.DeserializeData("data.txt");
            _originalData = File.ReadAllText("data.txt");

            // Підписка на події для обробки натискань клавіш Enter
            textBox1.KeyDown += SearchVacancy_KeyDown;
            textBox2.KeyDown += SearchVacancy_KeyDown;
            textBox3.KeyDown += SearchVacancy_KeyDown;
            textBox4.KeyDown += SearchVacancy_KeyDown;

            textBox5.KeyDown += SearchProfile_KeyDown;
            textBox6.KeyDown += SearchProfile_KeyDown;
            textBox7.KeyDown += SearchProfile_KeyDown;
            textBox8.KeyDown += SearchProfile_KeyDown;
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
                    File.WriteAllText("data.txt", _originalData);
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
                    MessageBox.Show("Ви працевлаштували робітника! Анкету архівовано.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    findButton2_Click(sender, EventArgs.Empty);
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
                    MessageBox.Show("Ви працевлаштувалися! Вакансію архівовано.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    findButton1_Click(sender, EventArgs.Empty);
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
                    MessageBox.Show("Ви відмовились від послуг! Анкету видалено.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    findButton2_Click(sender, EventArgs.Empty);

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
                    MessageBox.Show("Ви відмовились від послуг! Вакансію видалено.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    findButton1_Click(sender, EventArgs.Empty);
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
            using ProfileAdd form = new();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                JobExchange.AddWorksheet(form.UnemployedProfile);
                MessageBox.Show("Анкету успішно створено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                findButton2_Click(sender, EventArgs.Empty);
            }
        }

        // Кнопка додавання вакансії
        private void вакансіяРоботодавцяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using VacancyAdd form = new();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                JobExchange.AddWorksheet(form.JobVacancy);
                MessageBox.Show("Вакансію успішно створено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                findButton1_Click(sender, EventArgs.Empty);
            }
        }

        // Кнопка зміни анкети безробітного або вакансії
        private void Змінити_Click(object sender, EventArgs e)
        {
            var selectedItem = listBox1.SelectedItem;

            if (selectedItem is UnemployedProfile profile)
            {
                using ProfileEdit form = new(profile);
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Анкету успішно змінено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    findButton2_Click(sender, EventArgs.Empty);
                }
            }
            else if (selectedItem is JobVacancy vacancy)
            {
                using VacancyEdit form = new(vacancy);
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Вакансію успішно змінено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    findButton1_Click(sender, EventArgs.Empty);
                }
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
                using FormForPrintProfile form = new FormForPrintProfile(profile);
                form.ShowDialog();
            }
            else if (selectedItem is JobVacancy vacancy)
            {
                using FormForPrintVacancy form = new FormForPrintVacancy(vacancy);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Виберіть анкету робітника або вакансію зі списку для друку.");
            }
        }

        // Подія натискання клавіші Enter в полях пошуку вакансій
        private void SearchVacancy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                findButton1_Click(sender, EventArgs.Empty);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        // Подія натискання клавіші Enter в полях пошуку анкет безробітних
        private void SearchProfile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                findButton2_Click(sender, EventArgs.Empty);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
