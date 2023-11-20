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
        private List<Produto> historicoCadastros;
        public Historico()
        {
            InitializeComponent();
            this.historicoCadastros = historicoCadastros;

            // Exibe o histórico de cadastros
            dataGridViewHistorico.DataSource = historicoCadastros;
        }

            
    }
}
