using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        double total = 0.0d;

        private void button1_Click(object sender, EventArgs e)
        {
            CashContext csuper = new CashContext(comboBox1.SelectedItem.ToString());
            double totalPrices = 0d;
            totalPrices = csuper.GetResult(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text));
            total = total + totalPrices;
            listBox1.Items.Add("單價:" + textBox1.Text + "數量:" + textBox2.Text + " " + comboBox1.SelectedItem + "合計:" + totalPrices.ToString());
            label5.Text = total.ToString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CashContext csuper = new CashContext(comboBox1.SelectedItem.ToString());
            double totalPrices = 0d;
            totalPrices = csuper.GetResult(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text));
            total = total + totalPrices;
            listBox1.Items.Add("單價:" + textBox1.Text + "數量:" + textBox2.Text + " " + comboBox1.SelectedItem + "合計:" + totalPrices.ToString());
            label5.Text = total.ToString();


        }
    }
}
