using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week2
{
    public partial class Form1 : Form
    {
        double angka1 = 0;
        double angka2 = 0;
        string op = "";
        bool operatorClicked = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
        }

        private void InputAngka(string angka)
        {
            if (operatorClicked)
            {
                textBox1.Clear();
                operatorClicked = false;
            }

            textBox1.Text += angka;
        }

        // BUTTON FOR NUMBERS
        // BUTTON 1
        private void button1_Click(object sender, EventArgs e)
        {
            InputAngka("1");
        }

        // BUTTON 2
        private void button2_Click(object sender, EventArgs e)
        {
            InputAngka("2");
        }

        // BUTTON 3
        private void button3_Click(object sender, EventArgs e)
        {
            InputAngka("3");
        }

        // BUTTON 4
        private void button4_Click(object sender, EventArgs e)
        {
            InputAngka("4");
        }

        // BUTTON 5
        private void button5_Click(object sender, EventArgs e)
        {
            InputAngka("5");
        }

        // BUTTON 6
        private void button6_Click(object sender, EventArgs e)
        {
            InputAngka("6");
        }

        // BUTTON 7
        private void button7_Click(object sender, EventArgs e)
        {
            InputAngka("7");
        }

        // BUTTON 8
        private void button8_Click(object sender, EventArgs e)
        {
            InputAngka("8");
        }

        // BUTTON 9
        private void button9_Click(object sender, EventArgs e)
        {
            InputAngka("9");
        }

        // BUTTON 0
        private void button10_Click(object sender, EventArgs e)
        {
            InputAngka("0");
        }

        // BUTTON FOR OPERATORS
        // BUTTON +
        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") return;

            angka1 = Convert.ToDouble(textBox1.Text);
            op = "+";

            label1.Text = angka1.ToString();
            label3.Text = "_____+";

            textBox1.Clear();          
            operatorClicked = true;
        }

        // BUTTON -
        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") return;

            angka1 = Convert.ToDouble(textBox1.Text);
            op = "-";

            label1.Text = angka1.ToString();
            label3.Text = "_____-";

            textBox1.Clear();
            operatorClicked = true;
        }

        // BUTTON *
        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") return;

            angka1 = Convert.ToDouble(textBox1.Text);
            op = "*";

            label1.Text = angka1.ToString();
            label3.Text = "_____*";

            textBox1.Clear();
            operatorClicked = true;
        }

        // BUTTON /
        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") return;

            angka1 = Convert.ToDouble(textBox1.Text);
            op = "/";

            label1.Text = angka1.ToString();
            label3.Text = "_____/";

            textBox1.Clear();
            operatorClicked = true;
        }

        // BUTTON =
        private void button15_Click(object sender, EventArgs e)
        {
            if(op == "")
            {
                MessageBox.Show("Pilih operator terlebih dahulu");
                return;
            }

            if (textBox1.Text == "")
            {
                MessageBox.Show("Input angka kedua terlebih dahulu");
                return;
            }

            angka2 = Convert.ToDouble(textBox1.Text);
            label2.Text = angka2.ToString();

            double hasil = 0;

            switch (op)
            {
                case "+":
                    hasil = angka1 + angka2;
                    break;
                case "-":
                    hasil = angka1 - angka2;
                    break;
                case "*":
                    hasil = angka1 * angka2;
                    break;
                case "/":
                    if (angka2 != 0)
                        hasil = angka1 / angka2;
                    else
                    {
                        MessageBox.Show("Tidak bisa dibagi 0");
                        return;
                    }
                    break;
            }

            textBox1.Text = hasil.ToString();
        }

        // BUTTON CLEAR
        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            angka1 = 0;
            angka2 = 0;
            op = "";
            operatorClicked = false;
        }

        // LABEL ANGKA 1
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // LABEL ANGKA 2
        private void label2_Click(object sender, EventArgs e)
        {

        }

        // LABEL OPERATOR
        private void label3_Click(object sender, EventArgs e)
        {

        }

        // TEXTBOX
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
