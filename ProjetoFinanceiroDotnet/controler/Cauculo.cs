using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public class Cauculo
    {
        public double porcentagemVenda = 0;
        public double porcentagemEnvio = 0;
        public double custoTotalVenda = 0;
        public double custoTotalEnvio = 0;
        public double valorTotalVenda = 0;
        public double valorUnitarioProduto = 0;


        

        // Métodos de cauculo de Margem de custo de venda     
        public double CaucularPorcentagemCustoVenda()
        {
            porcentagemVenda= custoTotalVenda / valorTotalVenda * 100;
            return (porcentagemVenda);

        }
        //Margem de cauculo de custo de envio
        public double CaucularPorcentagemCustoEnvio()
        {

            porcentagemEnvio = custoTotalEnvio / valorTotalVenda * 100;
            return (porcentagemEnvio);
        }
        //Caucular o custo unitario da venda
        public double CaucularCustoUnitarioVenda()
        {

            return ((valorUnitarioProduto * porcentagemVenda) / 100);
        }

        //Caucular o custo unitario de envio
        public double CaucularCustoUnitarioEnvio()
        {
            return ((valorUnitarioProduto*porcentagemEnvio)/100);
        }

    }

}

