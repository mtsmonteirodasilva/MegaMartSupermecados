using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaMartSupermecados
{
    internal class HistoricoVenda
    {
        public DateTime DataVenda { get; set; }
        public List<Produto> ProdutosVendidos { get; set; }
        public double TotalVenda { get; set; }
    }
}
