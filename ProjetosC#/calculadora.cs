using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Calculadora feita em C# no Visual Studio colocar dentro do script do form para ações
// Acima são as bibliotecas ncessarias para rodar

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();//Inicializa um componente
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
          private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Obter os valores inseridos pelos usuários
                double valorInvestido = double.Parse(txtValorInvestido.Text);
                double taxaJuros = double.Parse(txtTaxaJuros.Text) / 100; // Converter para decimal
                int tempo = int.Parse(txtTempo.Text);

                // Fórmula para o cálculo do valor futuro
                double valorFuturo = valorInvestido * Math.Pow(1 + taxaJuros, tempo);
                double imposto = valorFuturo * 0.20;

                // Exibir o resultado
                lbResultado.Text = $"Valor Futuro: R$ {valorFuturo:0.00}";
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao calcular. Verifique os valores inseridos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbResultado_Click(object sender, EventArgs e)
        {

        }

        private void txtTaxaJuros_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTempo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_juros_Click(object sender, EventArgs e)
        {

        }
    }
}

