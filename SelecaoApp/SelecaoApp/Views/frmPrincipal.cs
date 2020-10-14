using SelecaoApp.Services.Services.FornecedoresServices;
using SelecaoApp.Services.Services.ProdutosServices;
using System;
using System.Windows.Forms;

namespace SelecaoApp
{
    public partial class frmPrincipal : Form
    {
        private IProdutosRepository produtosRepository;
        private IFornecedoresRepository fornecedoresRepository;

        public frmPrincipal(string usuario, IProdutosRepository produtosRepository, IFornecedoresRepository fornecedoresRepository)
        {
            InitializeComponent();

            this.produtosRepository = produtosRepository;
            this.fornecedoresRepository = fornecedoresRepository;
            
            lblUser.Text = usuario;
        }

        private void Fornecedores_Click(object sender, EventArgs e)
        {
            Form form = VerificaFormAberto(FormsEnums.frmFornecedores);
            if (form == null)
            {
                frmFornecedores fornecedores = new frmFornecedores(fornecedoresRepository);
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
                frmProdutos produtos = new frmProdutos(produtosRepository, fornecedoresRepository);
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
