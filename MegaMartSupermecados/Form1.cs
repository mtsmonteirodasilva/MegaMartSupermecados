using System;
using System.Windows.Forms;

namespace MegaMartSupermecados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CadastroProduto formCadastro = new CadastroProduto();
            formCadastro.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GerenciarEstoque formEstoque = new GerenciarEstoque();
            formEstoque.Show();
        }
    }
}
