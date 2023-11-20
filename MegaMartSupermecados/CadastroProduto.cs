﻿using System;
using System.Collections.Generic;
using System.Text;
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

                p.Nome = tx_descricao.Text;
                p.Codigo = Convert.ToInt32(tx_codigo.Text);
                double preco = p.PrecoAquisicao = Convert.ToDouble(tx_precoAquisicao.Text);
                double lucro = p.Lucro = Convert.ToDouble(tx_lucro.Text);

                double porcentagem = ((lucro * preco) / 100) + preco;
                p.preco = porcentagem;
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
            try
            {
                // Verifica se há produtos cadastrados
                if (produtos.Count == 0)
                {
                    MessageBox.Show("Não há produtos cadastrados para realizar a venda.");
                    return;
                }

                // Pode implementar aqui a lógica específica da venda, como atualizar estoque, registrar a venda, etc.
                // Neste exemplo, apenas exibiremos uma mensagem com os detalhes da venda.

                StringBuilder mensagemVenda = new StringBuilder();
                double totalVenda = 0;

                foreach (Produto produto in produtos)
                {
                    mensagemVenda.AppendLine($"Produto: {produto.Nome}, Código: {produto.Codigo}, Preço de Venda: {produto.preco}");
                    totalVenda += produto.preco;
                }

                mensagemVenda.AppendLine($"Total da Venda: {totalVenda}");

                MessageBox.Show(mensagemVenda.ToString(), "Detalhes da Venda");

                // Limpa a lista de produtos após a venda
                produtos.Clear();

                // Atualiza o DataGridView
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao realizar a venda: {ex.Message}");
            }

            
        }

        private void bt_historico_Click(object sender, EventArgs e)
        {
            Historico historico = new Historico();
            historico.Show();
        }
    }
 }


