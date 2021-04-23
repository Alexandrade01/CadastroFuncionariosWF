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
    public partial class TelaRelatorio : System.Windows.Forms.Form
    {
        public TelaRelatorio()
        {
            InitializeComponent();


        }
        public string BaseRelatorio { get; set; }
        private void TelaRelatorio_Load(object sender, EventArgs e)
        {
            if (!this.BaseRelatorio.Equals(""))
            {
                txtRelatorio.Text = this.BaseRelatorio;
            }
        }
    }
}
