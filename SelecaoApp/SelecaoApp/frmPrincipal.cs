using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelecaoApp
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Fornecedores_Click(object sender, EventArgs e)
        {
            //abre cadastros de fornecedores
        }

        private void Produtos_Click(object sender, EventArgs e)
        {
            //abre cadastro de produtos
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
