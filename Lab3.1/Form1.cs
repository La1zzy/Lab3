using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void ButtonOK_Click(object sender, EventArgs e)
        {
            string firstName = FirstName.Text;
            string lastName = LastName.Text;
            string birthYear = BirthYear.Text;
            string email = Email.Text;
            string month = MonthNumericUpDown.Value.ToString(); 
            string day = DayNumericUpDown.Value.ToString(); 
            string gender = MaleRadioButton.Checked ? "Чоловіча" : "Жіноча"; 

            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(birthYear) ||
                string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int year;
            if (!int.TryParse(birthYear, out year))
            {
                MessageBox.Show("Рік народження має бути числом.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OutputTextBox.AppendText($"Ім'я: {firstName}\n");
            OutputTextBox.AppendText($"Прізвище: {lastName}\n");
            OutputTextBox.AppendText($"Рік народження: {year}\n");
            OutputTextBox.AppendText($"Місяць: {month}\n"); 
            OutputTextBox.AppendText($"День: {day}\n"); 
            OutputTextBox.AppendText($"Стать: {gender}\n"); 
            OutputTextBox.AppendText($"Email: {email}\n\n");


            FirstName.Clear();
            LastName.Clear();
            BirthYear.Clear();
            Email.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
