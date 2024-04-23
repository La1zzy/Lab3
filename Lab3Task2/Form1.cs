using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3Task2
{
    public partial class Form1 : Form
    {
        private const double SmallPrice = 9;
        private const double MediumPrice = 12;
        private const double LargePrice = 15;

       
        private const double DiscountPercentage = 0.10;

        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click_1(object sender, EventArgs e)
        {
            double pricePerPhoto = 0.0;
            if (SmallRadioButton.Checked)
                pricePerPhoto = SmallPrice;
            else if (MediumRadioButton.Checked)
                pricePerPhoto = MediumPrice;
            else if (LargeRadioButton.Checked)
                pricePerPhoto = LargePrice;

            int quantity = (int)QuantityNumericUpDown.Value;

            double totalPrice = pricePerPhoto * quantity;

            if (quantity > 20)
                totalPrice *= (1 - DiscountPercentage);

            TotalPrice.Text = $"Total Price: {totalPrice:C}";
        }
    }
}