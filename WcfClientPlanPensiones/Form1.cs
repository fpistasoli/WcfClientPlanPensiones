using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfClientPlanPensiones.WebReference;


namespace WcfClientPlanPensiones
{
    public partial class Form1 : Form
    {
        private double companyPensionPlan = 0;
        private double personPensionPlan = 0;
        private double taxBase = 0;
        private double[] savings;

        private IService1 svc;

        public Form1()
        {
            InitializeComponent();
            svc = new Service1Client();
            savings = new double[9];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)//company pension plan
        {
            companyPensionPlan = double.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            personPensionPlan = double.Parse(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            taxBase = double.Parse(textBox3.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double result = svc.Deduct(companyPensionPlan, personPensionPlan, taxBase);
            MessageBox.Show("The result is " + result.ToString());
        }

        private void label4_Click(object sender, EventArgs e)
        {
 
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            savings[0] = double.Parse(textBox4.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            savings[1] = double.Parse(textBox5.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            savings[2] = double.Parse(textBox6.Text);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            savings[3] = double.Parse(textBox7.Text);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            savings[8] = double.Parse(textBox8.Text);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            savings[4] = double.Parse(textBox9.Text);
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            savings[7] = double.Parse(textBox10.Text);
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            savings[5] = double.Parse(textBox11.Text);
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            savings[6] = double.Parse(textBox12.Text);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            double[] result = svc.BitcoinInvestment(savings);
            MessageBox.Show("Total bitcoins: " + result[0] +
                "\nTotal investment: " + result[1] +
                "\nTotal earnings: " + result[2] +
                "\nProfitability: " + result[3] + "%");
        }

    }
}
