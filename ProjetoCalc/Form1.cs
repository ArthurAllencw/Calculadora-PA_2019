using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.ReadOnly = true; //Caixa de texto habilitada somente para leitura
            textBox2.Enabled = false; //Caixa de texto habilitada para edição
        }
        double V1, V2, Result; //Declaração de variáveis de somas e resultado
        char operação;

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text += 0;
            textBox1.Text += 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text += 1;
            textBox1.Text += 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text += 2;
            textBox1.Text += 2;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text += 3;
            textBox1.Text += 3;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text += 4;
            textBox1.Text += 4;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Text += 5;
            textBox1.Text += 5;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox2.Text += 6;
            textBox1.Text += 6;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox2.Text += 7;
            textBox1.Text += 7;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox2.Text += 8;
            textBox1.Text += 8;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox2.Text += 9;
            textBox1.Text += 9;
        }

        private void soma_Click(object sender, EventArgs e)
        {
            V1 = double.Parse(textBox2.Text); //colocar o primeiro valor com a conversão de double
            textBox1.Text += " + ";
            operação = '+';
            textBox2.Clear();
        }

        private void subtração_Click(object sender, EventArgs e)
        {
            V1 = double.Parse(textBox2.Text);
            textBox1.Text += " - ";
            operação = '-';
            textBox2.Clear();
        }

        private void multiplicação_Click(object sender, EventArgs e)
        {
            V1 = double.Parse(textBox2.Text);
            textBox1.Text += " * ";
            operação = '*';
            textBox2.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox1.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
            }
            catch
            {
                MessageBox.Show("Visor vazio!", "Calculadora diz:",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void divisão_Click(object sender, EventArgs e)
        {
            V1 = double.Parse(textBox2.Text);
            textBox1.Text += " / ";
            operação = '/';
            textBox2.Clear();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox2.Text = Math.PI.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Result = V1 * V2;
        }

        private void button21_Click(object sender, EventArgs e)
        {
        }

        private void igual_Click(object sender, EventArgs e)
        {
            V2 = double.Parse(textBox2.Text);
            switch (operação) //saber qual operação foi usada utilizando um switch case
            {
                case '+':
                    Result = V1 + V2;
                    break;
                case '-':
                    Result = V1 - V2;
                    break;
                case '*':
                    Result = V1 * V2;
                    break;
                case '/':
                    if(V2 == 0)
                    {
                        MessageBox.Show("Valor inválido");
                    }
                    else
                    {
                        Result = V1 / V2;
                    }
                    break;
            }
            textBox2.Clear();
            textBox2.Text = Result.ToString();
            textBox1.Text += " = " + Result;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }     
    }
}
