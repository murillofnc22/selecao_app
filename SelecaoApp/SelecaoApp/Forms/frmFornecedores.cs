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
    public partial class frmFornecedores : Form
    {
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
            //esse método vai carregar todos os fornecedores do banco para a DataGridView
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
        private void dgvFornecedores_DoubleClick(object sender, EventArgs e)
        {
            if (dgvFornecedores.CurrentRow.Index != -1)
            {
                SelectTabCadastro();
                //setar o modelo do fornecedor na tela de cadastros
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
    }
}
