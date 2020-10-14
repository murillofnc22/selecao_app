using SelecaoApp.Domain.Models.ProdutosModels;
using SelecaoApp.Services.Services.FornecedoresServices;
using SelecaoApp.Services.Services.ProdutosServices;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SelecaoApp
{
    public partial class frmProdutos : Form
    {
        Produtos model = new Produtos();        
        private IProdutosRepository _produtosRepository;
        private IFornecedoresRepository _fornecedoresRepository;
        public frmProdutos(IProdutosRepository produtosRepository, IFornecedoresRepository fornecedoresRepository)
        {
            InitializeComponent();
            _produtosRepository = produtosRepository;
            _fornecedoresRepository = fornecedoresRepository;
            txtBusca.Select();
        }
        private void frmProdutos_Load(object sender, EventArgs e)
        {
            CarregaProdutosCadastrados();
            SetFornecedores();
        }
        private void CarregaProdutosCadastrados()
        {
            dgvProdutos.DataSource = _produtosRepository.GetAllProdutosADO();
        }
        private void Pesquisa_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                ExecutaPesquisa();
        }
        private void ExecutaPesquisa()
        {
            dgvProdutos.DataSource = _produtosRepository.BuscaProdutosADO(txtBusca.Text);
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
            txtNome.Select();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluiProduto();
        }
        private void ExcluiProduto()
        {
            SetModel();
            _produtosRepository.Delete(model);
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
            numericQuantidade.Text = "0";
            model.id = 0;            
        }
        private void btnsalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
        private void Salvar()
        {
            if (Valida())
            {
                model.nome = txtNome.Text.Trim();
                model.idFornecedor = _fornecedoresRepository.GetIdFornecedorByName(cbFornecedor.Text.Trim());
                model.quantidade = Convert.ToInt32(numericQuantidade.Text.Trim());

                if (model.id == 0)
                    _produtosRepository.Add(model);
                else
                    _produtosRepository.Update(model);

                Limpar();
                CarregaProdutosCadastrados();
            }            
        }
        private bool Valida()
        {
            if(_fornecedoresRepository.GetIdFornecedorByName(cbFornecedor.Text.Trim()) == 0)
                return MessageBox.Show("O Fornecedor informado não existe!") != DialogResult.OK;

            if (string.IsNullOrEmpty(txtNome.Text))
                return MessageBox.Show("O Nome do Produto não pode ser vazio!") != DialogResult.OK;

            if (string.IsNullOrEmpty(cbFornecedor.Text))
                return MessageBox.Show("O Fornecedor não pode ser vazio!") != DialogResult.OK;

            if (string.IsNullOrEmpty(numericQuantidade.Text))
                return MessageBox.Show("A quantidade não pode ser vazia!") != DialogResult.OK;

            return true;
        }

        private void SetModel()
        {
            if (dgvProdutos.CurrentRow.Index != -1)
            {
                model.id = Convert.ToInt32(dgvProdutos.CurrentRow.Cells["id"].Value);

                model = _produtosRepository.GetById(model.id);

                txtNome.Text = model.nome;
                cbFornecedor.Text = _fornecedoresRepository.GetNomeFornecedorById(model.idFornecedor);
                numericQuantidade.Text = model.quantidade.ToString();
            }
        }
        private void SetFornecedores()
        {
            cbFornecedor.DataSource = _fornecedoresRepository.GetAll().Select(s => s.nome).ToList();
        }
    }
}
