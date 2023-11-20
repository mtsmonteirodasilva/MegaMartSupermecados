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
    public partial class Historico : Form
    {
        private List<HistoricoCadastro> historicoCadastro;
        private List<HistoricoVenda> historicoVendas;


            
        public Historico(List<HistoricoCadastro> historicoCadastro, List<HistoricoVenda> historicoVendas)
        {
            InitializeComponent();
            this.historicoCadastro = historicoCadastro;
            this.historicoVendas = historicoVendas;
            PopulateDataGridView();
        }
        private void PopulateDataGridView()
        {
           
            dataGridViewHistorico.Rows.Clear();
            foreach (var histCadastro in historicoCadastro)
            {
                dataGridViewHistorico.Rows.Add(histCadastro.DataCadastro, histCadastro.ProdutoCadastrado.Nome, histCadastro.ProdutoCadastrado.Codigo);
            }

            dataGridViewVendas.Rows.Clear();
            foreach (var histVenda in historicoVendas)
            {
                dataGridViewVendas.Rows.Add(histVenda.DataVenda, histVenda.TotalVenda);
            }
        }
    }
}
