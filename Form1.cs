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

namespace CalculatorWinForms
{
    public partial class Form1 : Form
    {
        float Valor1 = 0;
        float Valor2 = 0;
        string Operation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            txtResult.Text += 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtResult.Text += 1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtResult.Text += 2;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtResult.Text += 3;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResult.Text += 4;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResult.Text += 5;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResult.Text += 6;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResult.Text += 7;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResult.Text += 8;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResult.Text += 9;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int c = txtResult.TextLength;
            int flag = 0;
            string text = txtResult.Text;
            for (int i = 0; i < c; i++)
            { if (text[i].ToString() == ".") { flag = 1; break; } else { flag = 0; } }
            if (flag == 0)
            { txtResult.Text = txtResult.Text + "."; }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                Valor1 = float.Parse(txtResult.Text, CultureInfo.InvariantCulture);
                txtResult.Text = "";
                Operation = "SUM";
                lblOperations.Text = "+";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                Valor1 = float.Parse(txtResult.Text, CultureInfo.InvariantCulture);
                txtResult.Text = "";
                Operation = "SUBTRACTION";
                lblOperations.Text = "-";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                Valor1 = float.Parse(txtResult.Text, CultureInfo.InvariantCulture);
                txtResult.Text = "";
                Operation = "MULTIPLICATION";
                lblOperations.Text = "X";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                Valor1 = float.Parse(txtResult.Text, CultureInfo.InvariantCulture);
                txtResult.Text = "";
                Operation = "DIVISION";
                lblOperations.Text = "/";
            }
        }

        //BOTAO "C" lIMPA CAMPOS
        private void button5_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
        }


        //BOTAO "CE" lIMPA CAMPOS E VARIAVEL
        private void button4_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            Valor1 = 0;
            Valor2 = 0;
            lblOperations.Text = "";
        }


        //RESULTADO DAS OPERAÇOES
        private void button11_Click(object sender, EventArgs e)
        {
            Valor2 = float.Parse(txtResult.Text, CultureInfo.InvariantCulture);

            switch (Operation)
            {
                case "SUM":
                    txtResult.Text = Convert.ToString(Valor1 + Valor2, CultureInfo.InvariantCulture);
                    lblOperations.Text = "=";
                    break;
                case "SUBTRACTION":
                    txtResult.Text = Convert.ToString(Valor1 - Valor2, CultureInfo.InvariantCulture);
                    lblOperations.Text = "=";
                    break;
                case "DIVISION":
                    txtResult.Text = Convert.ToString(Valor1 / Valor2, CultureInfo.InvariantCulture);
                    lblOperations.Text = "=";
                    break;
                case "MULTIPLICATION":
                    txtResult.Text = Convert.ToString(Valor1 * Valor2, CultureInfo.InvariantCulture);
                    lblOperations.Text = "=";
                    break;
            }
        }

    }
}
