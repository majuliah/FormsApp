using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double saldo = 100.0;
            double saque = 10;
            saldo -= saque; //implementando comentários

            //MessageBox.Show($"O saldo da conta é {saldo}");

            //exercicio calcular media idades
            int idadeMaju = 24;
            int idadeAlex = 25;
            int idadeGabi = 26;

            int mediaIdades = (idadeMaju + idadeAlex + idadeGabi) / 3;
            MessageBox.Show($"A média das idades é {mediaIdades}");

            //O que acontece com o código?
            int pi = (int)3.14;
            //MessageBox.Show($"Valor de pi= {pi}");

        }
    }
}
