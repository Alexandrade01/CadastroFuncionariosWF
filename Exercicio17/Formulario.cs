using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio17
{
    public partial class Form : System.Windows.Forms.Form
    {
        private List<BaseFuncionario> listagemdeFuncionarios = new List<BaseFuncionario>();



        BaseFuncionario novofuncionario = new BaseFuncionario();

        public void ResetarTela()
        {
            numericUpDown1.ResetText();
            txtNome.Clear();
            txtSalario.Clear();
            gbVendedor.Enabled = gbGerente.Enabled = gbPeao.Enabled = false;
            
            MessageBox.Show("Salvo!");
        }

        public Form()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnAcesso_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtNome.Text.Trim().Equals("") || numericUpDown1.Value == 0 || txtSalario.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Dados Invalidos!","Erro de dados!", MessageBoxButtons.OK);
                    return;
                }
                novofuncionario.Nome = txtNome.Text;
                novofuncionario.Codigo = Convert.ToInt32(numericUpDown1.Value);
                novofuncionario.Salario = Convert.ToDouble(txtSalario.Text);

                gbVendedor.Enabled = gbGerente.Enabled = gbPeao.Enabled = true;
            



            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Dados Invalidos!", MessageBoxButtons.OK);
                return;
            }

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var novogerente = new FuncionarioGerente
                {
                    Nome = novofuncionario.Nome,
                    Codigo = novofuncionario.Codigo,
                    Salario = novofuncionario.Codigo,
                    QtdeFuncionariosSubordinados = Convert.ToInt32(numericgerente.Value),
                    BonusEmReais = Convert.ToDouble(txtbonus.Text)
                };

                listagemdeFuncionarios.Add(novogerente);
                MessageBox.Show("Salvo!");
                ResetarTela();

               
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Dados Invalidos!", MessageBoxButtons.OK);
                return;
            }

           


        }

        private void BtnExibir_Click(object sender, EventArgs e)
        {
            TelaRelatorio novatela = new TelaRelatorio();
            string Relatorio = string.Empty;
            foreach (var relatorio in listagemdeFuncionarios)
            {
                Relatorio += relatorio.ToString() +Environment.NewLine;
            }

            novatela.BaseRelatorio = Relatorio;
            novatela.ShowDialog();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                var NovoVendedor = new FuncionarioVendedor
                {
                    Nome = novofuncionario.Nome,
                    Codigo = novofuncionario.Codigo,
                    Salario = novofuncionario.Salario,
                    MetaDeVendaMesEmReais = Convert.ToDouble(txtMetas.Text),
                    VendasdoMesEmReais = Convert.ToDouble(txtVendas.Text),
                    PorcentagemSobreVendas = Convert.ToInt32(txtporcent.Text)
                };
               
                
                ResetarTela();
                listagemdeFuncionarios.Add(NovoVendedor);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Dados Invalidos!", MessageBoxButtons.OK);
                return;
            }

        }

        private void SavePeao(object sender, EventArgs e)
        {
            try
            {
                var NovoPeao = new FuncionarioPeao
                {
                    Nome = novofuncionario.Nome,
                    Codigo = novofuncionario.Codigo,
                    Salario = novofuncionario.Salario,
                    HoraExtraemReais = Convert.ToInt32(txtHoraExtra.Text),
                };

             
                ResetarTela();
                listagemdeFuncionarios.Add(NovoPeao);


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Dados Invalidos!", MessageBoxButtons.OK);
                return;
            }
        }
    }
}





