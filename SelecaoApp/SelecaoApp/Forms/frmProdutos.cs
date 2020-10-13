using SelecaoApp.Infra.Repository;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SelecaoApp
{
    public partial class frmProdutos : Form
    {
        Produtos model = new Produtos();
        private RepositoryProduto db = new RepositoryProduto();
        public frmProdutos()
        {
            InitializeComponent();
        }
        private void frmProdutos_Load(object sender, EventArgs e)
        {
            CarregaProdutosCadastrados();
            SetFornecedores();
        }
        private void CarregaProdutosCadastrados()
        {
            dgvProdutos.AutoGenerateColumns = false;
            dgvProdutos.DataSource = db.List();
        }
        private void Pesquisa_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                ExecutaPesquisa();
        }
        private void ExecutaPesquisa()
        {
            //esse método fará a pesquisa no banco de dados.
            MessageBox.Show("Pesquisa!");
        }
        private void dgvProdutos_DoubleClick(object sender, EventArgs e)
        {
            if (dgvProdutos.CurrentRow.Index != -1)
            {
                SetModel();
                SelectTabCadastro();
            }
        }        

        private void SelectTabCadastro()
        {
            tcProdutos.SelectedTab = tpCadastro;
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluiProduto();
        }
        private void ExcluiProduto()
        {
            SetModel();
            db.Delete(model);
            CarregaProdutosCadastrados();
            Limpar();            
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
            SelectTabCadastro();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        private void Limpar()
        {
            txtNome.Text = cbFornecedor.Text = "";
            dudQuantidade.Text = "0";
            model.id = 0;            
        }
        private void btnsalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
        private void Salvar()
        {
            model.nome = txtNome.Text.Trim();
            model.fornecedor = GetIdFornecedor(cbFornecedor.Text.Trim());
            model.quantidade = Convert.ToInt32(dudQuantidade.Text.Trim());

            if (model.id == 0)
                db.Add(model);
            else
                db.Update(model);

            Limpar();
            CarregaProdutosCadastrados();
        }
        private void SetModel()
        {
            if (dgvProdutos.CurrentRow.Index != -1)
            {
                model.id = Convert.ToInt64(dgvProdutos.CurrentRow.Cells["id"].Value);

                model = db.GetEntityById(model.id);

                txtNome.Text = model.nome;
                cbFornecedor.Text = GetNomeFornecedor(model.fornecedor);
                dudQuantidade.Text = model.quantidade.ToString();
            }
        }
        private string GetNomeFornecedor(long id)
        {
            string nome = "";
            using (DBEntities db = new DBEntities())
            {
                nome = db.Fornecedores.Where(x => x.id == id).FirstOrDefault().nome;
            }
            return nome;
        }
        private long GetIdFornecedor(string nome)
        {
            long id = 0;
            using (DBEntities db = new DBEntities())
            {
                id = db.Fornecedores.Where(x => x.nome == nome).FirstOrDefault().id;
            }
            return id;
        }
        private void SetFornecedores()
        {
            using (DBEntities db = new DBEntities())
            {
                cbFornecedor.DataSource = db.Fornecedores.ToList().Select(s => s.nome).ToList();
            }            
        }
    }
}
