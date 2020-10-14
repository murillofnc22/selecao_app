using SelecaoApp.Domain.Models.FornecedoresModels;
using SelecaoApp.Services.Services.FornecedoresServices;
using System;
using System.Windows.Forms;

namespace SelecaoApp
{
    public partial class frmFornecedores : Form
    {
        private Fornecedores model = new Fornecedores();
        private IFornecedoresRepository _fornecedoresRepository;        
        
        public frmFornecedores(IFornecedoresRepository fornecedoresRepository)
        {
            InitializeComponent();
            _fornecedoresRepository = fornecedoresRepository;
            txtPesquisa.Select();
        }

        private void frmFornecedores_Load(object sender, EventArgs e)
        {
            CarregaFornecedoresCadastrados();
        }
        private void CarregaFornecedoresCadastrados()
        {
            dgvFornecedores.DataSource = _fornecedoresRepository.GetAllFornecedoresADO();
        }
        private void Pesquisa_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                ExecutaPesquisa();
        }
        private void ExecutaPesquisa()
        {
            dgvFornecedores.DataSource = _fornecedoresRepository.BuscaFornecedoresADO(txtPesquisa.Text);
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
            txtNome.Select();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            ExcluiFornecedor();
        }
        private void ExcluiFornecedor()
        {
            SetModel();
            _fornecedoresRepository.Delete(model);
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
            if (Valida())
            {
                model.nome = txtNome.Text.Trim();
                model.cnpj = txtCnpj.Text.Trim();
                model.endereco = txtEndereco.Text.Trim();
                model.ativo = cbAtivo.Checked;

                if (model.id == 0)
                    _fornecedoresRepository.Add(model);
                else
                    _fornecedoresRepository.Update(model);

                Limpar();
                CarregaFornecedoresCadastrados();
            }            
        }

        private bool Valida()
        {
            if (string.IsNullOrEmpty(txtNome.Text))
                return MessageBox.Show("O Nome do Fornecedor não pode ser vazio!") != DialogResult.OK;

            if (string.IsNullOrEmpty(txtCnpj.Text))
                return MessageBox.Show("O CNPJ do Fornecedor não pode ser vazio!") != DialogResult.OK;

            return true;
        }

        private void SetModel()
        {
            if (dgvFornecedores.CurrentRow.Index != -1)
            {
                model.id = Convert.ToInt32(dgvFornecedores.CurrentRow.Cells["id"].Value);
                model = _fornecedoresRepository.GetById(model.id);

                txtNome.Text = model.nome;
                txtCnpj.Text = model.cnpj;
                txtEndereco.Text = model.endereco;
                cbAtivo.Checked = model.ativo;
            }
        }
    }
}
