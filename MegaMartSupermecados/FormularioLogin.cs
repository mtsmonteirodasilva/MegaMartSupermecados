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
    public partial class FormularioLogin : Form
    {
        public FormularioLogin()
        {
            InitializeComponent();
        }

        private void bt_entrar_Click(object sender, EventArgs e)
        {
            string usuario = "admin";
            string senha = "123";

            if(tx_usuario.Text == usuario & tx_senha.Text == senha) 
            { 
                Form1 formP = new Form1();
                formP.Show();
            }
            else
            {
                MessageBox.Show("Usuario ou senha incorretos.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
