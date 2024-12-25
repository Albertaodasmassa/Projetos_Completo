using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class CalculadoraNota : Form
    {
        public CalculadoraNota()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
             private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Obter os valores inseridos pelos usuários
                double nota1 = double.Parse(txtnota1.Text);
                double nota2 = double.Parse(txtnota2.Text) / 100; // Converter para decimal
                double nota3 = double.Parse(txtnota3.Text);

                // Fórmula para o cálculo do valor futuro
                double res = (nota1 + nota2 + nota3) / 3;
                if (res >= 6)
                {
                    lb_status.Text = "Aluno Aprovado";
                }
                else
                {
                    lb_status.Text = "Aluno Reprovado";
                }

                // Exibir o resultado
                lb_resultado.Text = $"A nota do aluno é: {res:0.00}";
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao calcular. Verifique os valores inseridos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }
