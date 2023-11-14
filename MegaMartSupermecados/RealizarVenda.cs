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
    public partial class RealizarVenda : Form
    {
     
        List<Produto> carrinhoDeCompras = new List<Produto>();

        public RealizarVenda()
        {
            InitializeComponent();
        }

        private void bt_vender_Click(object sender, EventArgs e)
        {

        }
    }
}
