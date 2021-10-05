using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wendell_Chaves_P1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RB_Adição_CheckedChanged(object sender, EventArgs e)
        {
            double num01 = Convert.ToDouble(TB_Num01.Text);
            double num02 = Convert.ToDouble(TB_Num02.Text);
            double Soma = num01 + num02;
            TB_Resultado.Text = Soma.ToString();
        }

        private void RB_Subtração_CheckedChanged(object sender, EventArgs e)
        {
            double num01 = Convert.ToDouble(TB_Num01.Text);
            double num02 = Convert.ToDouble(TB_Num02.Text);
            double Subtração = num01 - num02;
            TB_Resultado.Text = Subtração.ToString();
        }

        private void RB_Multiplicação_CheckedChanged(object sender, EventArgs e)
        {
            double num01 = Convert.ToDouble(TB_Num01.Text);
            double num02 = Convert.ToDouble(TB_Num02.Text);
            double Multiplicação = num01 * num02;
            TB_Resultado.Text = Multiplicação.ToString();
        }

        private void RB_Divisão_CheckedChanged(object sender, EventArgs e)
        {
            double num01 = Convert.ToDouble(TB_Num01.Text);
            double num02 = Convert.ToDouble(TB_Num02.Text);
            if (num02 != 0)
            {
                double Divisão = num01 / num02;
                TB_Resultado.Text = Divisão.ToString();
            }
            else
                 TB_Resultado.Text = "";       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TB_Num01.Text = "";
            TB_Num02.Text = "";
            TB_Resultado.Text = "";
            TB_Num01.Focus();
        }
    }
}
