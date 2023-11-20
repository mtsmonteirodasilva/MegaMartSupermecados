using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaMartSupermecados
{
    class Produto
    {
        public string Nome { get; set; }
        public int Codigo { get; set;}
        public double PrecoAquisicao { get; set;}
        public double Lucro { get; set;}
        public double preco { get; set;}
        public int Estoque {  get; set;}

        public Produto()
        {

        }

        public Produto(string nome, int codigo, double precoAquisicao, double lucro, double valorVenda, int estoque)
        {
            Nome = nome;
            Codigo = codigo;
            PrecoAquisicao = precoAquisicao;
            Lucro = lucro;
            preco = valorVenda;
            Estoque = estoque;
        }
        public void AdicionarEstoque(int quantidade)
        {
            Estoque += quantidade;
        }

        // Método para remover quantidade do estoque
        public void RemoverEstoque(int quantidade)
        {
            if (Estoque >= quantidade)
            {
                Estoque -= quantidade;
            }
            else
            {
                throw new InvalidOperationException("Quantidade em estoque insuficiente.");
            }
        }
    }
}
