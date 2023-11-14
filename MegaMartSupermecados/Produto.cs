using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaMartSupermecados
{
    class Produto
    {
        public string Descricao { get; set; }
        public string Codigo { get; set;}
        public double PrecoAquisicao { get; set;}
        public double Lucro { get; set;}
        public double ValorVenda { get; set;}

        public Produto()
        {

        }

        public Produto(string descricao, string codigo, double precoAquisicao, double lucro, double valorVenda)
        {
            Descricao = descricao;
            Codigo = codigo;
            PrecoAquisicao = precoAquisicao;
            Lucro = lucro;
            ValorVenda = valorVenda;
        }
    }
}
