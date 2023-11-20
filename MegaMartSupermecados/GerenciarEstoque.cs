using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaMartSupermecados
{
    public partial class GerenciarEstoque : Form
    {
        private List<Produto> Estoque = new List<Produto>();

        public GerenciarEstoque()
        {
            InitializeComponent();
           
        }
        private void GerenciamentoEstoque_Load(object sender, EventArgs e)
        {
            AtualizarDataGridView();
        }
        private void AtualizarDataGridView()
        {
            dataGridViewEstoque.DataSource = null;
            dataGridViewEstoque.Refresh();
            dataGridViewEstoque.DataSource = Estoque;
        }



        private void bt_remover_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridViewEstoque.CurrentCell.RowIndex;
                Produto produtoSelecionado = Estoque[index];

                // Pode-se implementar uma lógica para remover quantidade do estoque
                // Aqui, apenas exibimos um MessageBox como exemplo

                int quantidade = Convert.ToInt32(tx_quantidadeEstoque.Text);
                produtoSelecionado.RemoverEstoque(quantidade);

                MessageBox.Show($"Estoque atualizado para o produto {produtoSelecionado.Nome}. Nova quantidade em estoque: {produtoSelecionado.Estoque}");

                // Atualiza o DataGridView
                AtualizarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao remover do estoque: {ex.Message}");
            }
        }

        private void bt_adicionar_Click_1(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridViewEstoque.CurrentCell.RowIndex;
                Produto produtoSelecionado = Estoque[index];

                // Pode-se implementar uma lógica para adicionar quantidade ao estoque
                // Aqui, apenas exibimos um MessageBox como exemplo

                int quantidade = Convert.ToInt32(tx_quantidadeEstoque.Text);
                produtoSelecionado.AdicionarEstoque(quantidade);

                MessageBox.Show($"Estoque atualizado para o produto {produtoSelecionado.Nome}. Nova quantidade em estoque: {produtoSelecionado.Estoque}");

                // Atualiza o DataGridView
                AtualizarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar ao estoque: {ex.Message}");
            }
        }
    }
}