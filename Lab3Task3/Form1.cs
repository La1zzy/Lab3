using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3Task3
{
    public partial class Form1 : Form
    {
        private readonly double porscheTaycanPrice = 4000000;
        private readonly double porscheTaycanTurboPrice = 6800000;
        private readonly double porscheTaycanTurboSPrice = 9250000;

        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click_1(object sender, EventArgs e)
        {
            double carPrice = 0;

            if (checkBox1.Checked)
            {
                carPrice += porscheTaycanPrice;
            }

            if (checkBox2.Checked)
            {
                carPrice += porscheTaycanTurboPrice;
            }

            if (checkBox3.Checked)
            {
                carPrice += porscheTaycanTurboSPrice;
            }

            textBox1.Text = carPrice.ToString();
        }
    }
}
