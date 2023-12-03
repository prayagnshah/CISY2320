using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            // Taking the input into string and then later we will convert it to numeric
            string input = textBox1.Text;

            // Check if the input is not empty and show the error message
            double numericValue = 0;
            if (string.IsNullOrEmpty(input) || !double.TryParse(input, out numericValue))
            {
                label4.Text = "You must input a numeric value for the unit price";
                numericValue = 0;
                return;
            }

            if (comboBox2.SelectedItem == null)
            {
                label4.Text = "You must choose a quantity";
                return;
            }

            else if (comboBox1.SelectedIndex == -1)
            {
                label4.Text = "You must select a province";
                return;
            }

            // Calculate Combox1 selection into numeric value
            int quantity = int.Parse(comboBox2.SelectedItem.ToString());

            // Calculate the total value
            double total = numericValue * quantity;

            // Getting the selected province into string
            string selectedProvince = comboBox1.SelectedItem.ToString();

            // Calculate the tax rate based on province selection
            double taxRate;
            switch (selectedProvince)
            {
                case "Ontario":
                    taxRate = 0.13;
                    break;
                case "New Brunswick":
                case "Newfoundland and Labrador":
                case "Nova Scotia":
                case "Prince Edward Island":
                    taxRate = 0.15;
                    break;
                default:
                    taxRate = 0.05;
                    break;
            }

            // Calculate tax amount
            double taxAmount = total * taxRate;

            // Calculate the total with Tax
            double taxableAmount = total + taxAmount;

            // Displaying message at end after all the inputs
            label4.Text = "Subtotal before GST/HST: " + total + "\n" +
               "GST/HST: " + taxAmount + "\n" +
                "Total with GST/HST: " + taxableAmount;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
