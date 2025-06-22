using Common.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using Wrapper;
using Wrapper.Interface;

namespace Builder
{
    public partial class Form1 : Form
    {
        private ICalculator calculator;
        private IAdvanceCalculator advanceCalculator;

        public Form1()
        {
            InitializeComponent();
            calculator = new Calculator();
            advanceCalculator = new AdvanceCalculator();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            var x = int.Parse(textBox_x.Text);
            var y = int.Parse(textBox_y.Text);
            label_add.Text = calculator.Add(x, y).ToString();
        }

        private void button_subtract_Click(object sender, EventArgs e)
        {
            var x = int.Parse(textBox_x.Text);
            var y = int.Parse(textBox_y.Text);
            label_subtract.Text = calculator.Subtract(x, y).ToString();
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            var x = int.Parse(textBox_x.Text);
            var y = int.Parse(textBox_y.Text);
            label_multiply.Text = calculator.Multiply(x, y).ToString();
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            var x = int.Parse(textBox_x.Text);
            var y = int.Parse(textBox_y.Text);
            label_divide.Text = calculator.Divide(x, y).ToString();
        }

        private void button_power_Click(object sender, EventArgs e)
        {
            var x = int.Parse(textBox_x.Text);
            var y = int.Parse(textBox_y.Text);
            label_power.Text = advanceCalculator.Power(x, y).ToString(CultureInfo.InvariantCulture);
        }

        private void button_squareRoot_Click(object sender, EventArgs e)
        {
            var x = int.Parse(textBox_x.Text);
            label_squareRoot.Text = advanceCalculator.SquareRoot(x).ToString(CultureInfo.InvariantCulture);
        }
    }
}
