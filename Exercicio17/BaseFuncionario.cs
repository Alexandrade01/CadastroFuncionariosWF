using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio17
{
    class BaseFuncionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public virtual double CalculaSalario()
        {
            return Salario;
        }

        public override string ToString()
        {
            StringBuilder newstring = new StringBuilder();
            newstring.AppendLine("Código :" + Codigo);
            newstring.AppendLine("Nome :" +     Nome);
            newstring.AppendLine("Salario :" + "R$" +CalculaSalario().ToString("0.00"));

            return newstring.ToString();
            
            
            
        }
    }
}
