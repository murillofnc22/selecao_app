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
            Form form = VerificaFormAberto(FormsEnums.frmFornecedores);
            if (form == null)
            {
                frmFornecedores fornecedores = new frmFornecedores();
                fornecedores.Show(this);
            }
            else
                form.Activate();
        }

        private void Produtos_Click(object sender, EventArgs e)
        {
            Form form = VerificaFormAberto(FormsEnums.frmProdutos);
            if (form == null)
            {
                frmProdutos produtos = new frmProdutos();
                produtos.Show(this);
            }
            else
                form.Activate();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Form VerificaFormAberto(FormsEnums formName)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name == formName.ToString())
                    return frm;
            }
            return null;
        }
    }
}
