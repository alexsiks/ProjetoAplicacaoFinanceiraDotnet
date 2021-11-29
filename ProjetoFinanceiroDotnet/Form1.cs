using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoFinanceiroDotnet.view;

namespace ProjetoFinanceiroDotnet
{
    public partial class Form1 : Form
    {
        Thread t1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Importante realizar a importação da biblioteca Thread*/

            //Fechar a janela inicial sem Finalizar o programa.
            this.Close();
            //t1 é o objeto que vai chamar o método "Abrir Janela".
            t1 = new Thread(abrirJanela);

            
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
            
        }
        //Metodo de Abertura de Janela.
        private void abrirJanela(object obj)
        {

            Application.Run(new CaucularCustoUnitario());
        }
    }
}
