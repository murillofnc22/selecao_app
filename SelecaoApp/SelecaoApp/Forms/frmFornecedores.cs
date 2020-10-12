using SelecaoApp.Infra.Repository.Generic;
using System;
using System.Windows.Forms;

namespace SelecaoApp
{
    public partial class frmFornecedores : Form
    {
        private Entities.Fornecedores model = new Entities.Fornecedores();
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
            using (RepositoryFornecedor fornecedor = new RepositoryFornecedor())
            {
                dgvFornecedores.DataSource = fornecedor.List();
            }
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
            //excluir o fornecedor selecionado aqui.
            MessageBox.Show("Apaga!");
            CarregaFornecedoresCadastrados();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            SelectTabCadastro();
            //setar um modelo novo na tela de cadastros
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        private void Limpar()
        {
            //Limpas os campos dos modelo
            MessageBox.Show("Cancelou!");
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
        private void Salvar()
        {
            //Insere ou atualiza o fornecedor
            MessageBox.Show("Salvou!");
            CarregaFornecedoresCadastrados();
        }
        private void SetModel()
        {
            if (dgvFornecedores.CurrentRow.Index != -1)
            {
                model.Id = Convert.ToInt64(dgvFornecedores.CurrentRow.Cells["id"].Value);
                using (RepositoryFornecedor db = new RepositoryFornecedor())
                {
                    model = db.GetEntityById(model.Id);

                    txtNome.Text = model.Nome;
                    txtCnpj.Text = model.CNPJ;
                    txtEndereco.Text = model.Endereco;
                    cbAtivo.Checked = model.Ativo;
                }
            }
        }
    }
}
