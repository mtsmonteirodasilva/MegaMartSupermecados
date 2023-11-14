using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MegaMartSupermecados
{
    
    public partial class CadastroProduto : Form
    {
        List<Produto> produtos = new List<Produto>();
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Produto p = new Produto();

                p.Descricao = tx_descricao.Text;
                p.Codigo = tx_codigo.Text;
                double preco = p.PrecoAquisicao = Convert.ToDouble(tx_precoAquisicao.Text);
                double lucro = p.Lucro = Convert.ToDouble(tx_lucro.Text);

                double porcentagem = ((lucro * preco) / 100) + preco;
                p.ValorVenda = porcentagem;
                tb_venda.Text = porcentagem.ToString();
                produtos.Add(p);

                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView1.DataSource = produtos;

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Formato invalido!");
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro inesperado!");
            }
        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            tx_descricao.Clear();
            tx_codigo.Clear();
            tx_precoAquisicao.Clear();
            tx_lucro.Clear();
            tb_venda.Clear();
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            produtos.RemoveAt(index);

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = produtos;
        }

        private void bt_realizarVenda_Click(object sender, EventArgs e)
        {
            RealizarVenda formVenda = new RealizarVenda();
            formVenda.Show();
        }
    }
}
