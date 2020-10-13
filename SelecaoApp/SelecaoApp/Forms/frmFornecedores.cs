using SelecaoApp.Infra.Repository.Generic;
using System;
using System.Windows.Forms;

namespace SelecaoApp
{
    public partial class frmFornecedores : Form
    {
        private Fornecedores model = new Fornecedores();
        private RepositoryFornecedor db = new RepositoryFornecedor();
        public frmFornecedores()
        {
            InitializeComponent();
        }
        private void frmFornecedores_Load(object sender, EventArgs e)
        {
            CarregaFornecedoresCadastrados();
        }
        private void CarregaFornecedoresCadastrados()
        {
            dgvFornecedores.AutoGenerateColumns = false;
            dgvFornecedores.DataSource = db.List();
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
        private void dgvFornecedores_DoubleClick(object sender, EventArgs e)
        {
            if (dgvFornecedores.CurrentRow.Index != -1)
            {
                SetModel();
                SelectTabCadastro();
            }
        }
        private void SelectTabCadastro()
        {
            tcFornecedor.SelectedTab = tpCadastro;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            ExcluiFornecedor();
        }
        private void ExcluiFornecedor()
        {
            SetModel();
            db.Delete(model);
            CarregaFornecedoresCadastrados();
            Limpar();
        }
        private void Novo_Click(object sender, EventArgs e)
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
            txtNome.Text = txtCnpj.Text = txtEndereco.Text = "";
            model.id = 0;
            model.ativo = true;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
        private void Salvar()
        {
            model.nome = txtNome.Text.Trim();
            model.cnpj = txtCnpj.Text.Trim();
            model.endereco = txtEndereco.Text.Trim();
            model.ativo = cbAtivo.Checked;

            if (model.id == 0)
                db.Add(model);
            else
                db.Update(model);

            Limpar();
            CarregaFornecedoresCadastrados();
        }
        private void SetModel()
        {
            if (dgvFornecedores.CurrentRow.Index != -1)
            {
                model.id = Convert.ToInt64(dgvFornecedores.CurrentRow.Cells["id"].Value);
                model = db.GetEntityById(model.id);

                txtNome.Text = model.nome;
                txtCnpj.Text = model.cnpj;
                txtEndereco.Text = model.endereco;
                cbAtivo.Checked = model.ativo;
            }
        }
    }
}
