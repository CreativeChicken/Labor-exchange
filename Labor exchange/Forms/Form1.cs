using Labor_exchange.Models;

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
    }
}
