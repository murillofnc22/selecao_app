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
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }
        private void frmProdutos_Load(object sender, EventArgs e)
        {
            CarregaProdutosCadastrados();
        }
        private void CarregaProdutosCadastrados()
        {
            //esse método vai carregar todos os produtos do banco para a DataGridView
            MessageBox.Show("Carregou!");
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
                SelectTabCadastro();
                //setar o modelo do produto na tela de cadastros
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
            //excluir o produto selecionado aqui.
            MessageBox.Show("Apaga!");
            CarregaProdutosCadastrados();
        }
        private void btnNovo_Click(object sender, EventArgs e)
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
        private void btnsalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
        private void Salvar()
        {
            //Insere ou atualiza o fornecedor
            MessageBox.Show("Salvou!");
            CarregaProdutosCadastrados();
        }
    }
}
