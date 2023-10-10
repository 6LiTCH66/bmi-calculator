using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bmi_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string check_bmi_status(double bmi)
        {
            if (bmi > 18.5 && bmi < 25)
            {
                return "optimal";

            }else if(bmi < 18.5)
            {
                return "underweight";
            }
            else
            {
                return "overweight";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double bmi = 0;
            double pounds = 0;
            double inches = 0;

            try
            {
                pounds = double.Parse(textBox1.Text);
                inches = double.Parse(textBox2.Text);

                bmi = (pounds / (inches * inches)) * 703;
                string bmi_status = check_bmi_status(bmi);

                label3.Text = $"BMI: {Math.Round(bmi, 2)} \nStatus: {bmi_status}";
            }
            catch
            {
                MessageBox.Show("Input string was not in a correct format.");
            }
        }
    }
}
