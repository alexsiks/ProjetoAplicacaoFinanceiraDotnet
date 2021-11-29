using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharp_Shell;

namespace ProjetoFinanceiroDotnet.view
{
    public partial class CaucularCustoUnitario : Form
    {
        Cauculo cauculo;
        public CaucularCustoUnitario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cauculo = new Cauculo();

            try
            {

                // Setando os valores para a classe de Cauculo
                cauculo.valorTotalVenda = Convert.ToDouble(valorTotalVenda_Textbox.Text);
                cauculo.valorUnitarioProduto = Convert.ToDouble(valorUnitarioProduto_TextBox.Text);
                cauculo.custoTotalVenda = Convert.ToDouble(custoTotalVenda_TextBox.Text);
                cauculo.custoTotalEnvio = Convert.ToDouble(custoTotalEnvio_TextBox.Text);


                //Retorno do cauculo de margem da venda.
                double porcentagemCustoVenda = cauculo.CaucularPorcentagemCustoVenda();
                margemCustoVenda_TextBox.Text = Convert.ToString(String.Format("{0:n2} %",porcentagemCustoVenda));
                //Retorno de cauculo de margem de Envio.
                double porcentagemCustoEnvio = cauculo.CaucularPorcentagemCustoEnvio();
                margemCustoEnvio_TextBox.Text = Convert.ToString(String.Format("{0:n2} %",porcentagemCustoEnvio));

                //Caucular o custo unitario da venda.
                double custoUnitarioVenda = cauculo.CaucularCustoUnitarioVenda();
                custoUnitarioVenda_TextBox.Text = Convert.ToString(String.Format("R$ {0:n2}",custoUnitarioVenda));

                //Caucular o custo unitario de envio.
                double custoUnitarioEnvio = cauculo.CaucularCustoUnitarioEnvio();
                custoUnitarioEnvio_TextBox.Text = Convert.ToString(String.Format("R$ {0:n2}",custoUnitarioEnvio));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Mensagem de Exceção",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }



        }

        
    }
}
