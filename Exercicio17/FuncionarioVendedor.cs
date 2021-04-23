using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio17
{
    class FuncionarioVendedor : BaseFuncionario
    {
        public double MetaDeVendaMesEmReais { get; set; }
        public double VendasdoMesEmReais { get; set; }

        public double PorcentagemSobreVendas { get; set; }

        public override double CalculaSalario()
        {
            if (VendasdoMesEmReais >= MetaDeVendaMesEmReais)
            {
                return Salario + (VendasdoMesEmReais * ((double)PorcentagemSobreVendas /100));
            }
            else
            {
                return base.CalculaSalario();
            }
           
        }

        public override string ToString()
        {
            StringBuilder newstring = new StringBuilder();
            newstring.AppendLine("Meta de vendas R$" + MetaDeVendaMesEmReais.ToString("0.00"));
            newstring.AppendLine("Vendas dos mes R$" + VendasdoMesEmReais.ToString("0.00"));
            newstring.AppendLine("Porcentagem sobre vendas %" + PorcentagemSobreVendas.ToString("0.0"));

            return base.ToString() + newstring + Environment.NewLine;

        }






    }
}
