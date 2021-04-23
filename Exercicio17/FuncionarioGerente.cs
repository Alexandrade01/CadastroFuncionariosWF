using System;

namespace Exercicio17
{
    class FuncionarioGerente : BaseFuncionario
    {
        public double BonusEmReais
        {
            get;set;
           
        }

        public int QtdeFuncionariosSubordinados { get; set; }

        public override double CalculaSalario()
        {
            return base.CalculaSalario() + BonusEmReais;
        }

        public override string ToString()
        {




            return base.ToString()  + "Bonus :" + BonusEmReais.ToString("0.00") 
                + Environment.NewLine + "Quantidade de subordinado :" + QtdeFuncionariosSubordinados + Environment.NewLine;

        }
    }
}
