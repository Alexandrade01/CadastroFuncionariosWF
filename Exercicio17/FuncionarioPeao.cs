using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio17
{
    class FuncionarioPeao:BaseFuncionario
    {

        public double HoraExtraemReais { get; set; }
        public override double CalculaSalario()
        {
            return base.CalculaSalario() + HoraExtraemReais;
        }
        public override string ToString()
        {
            return base.ToString() + "Valor da hora extra " + HoraExtraemReais + Environment.NewLine;
        }
    }
}
