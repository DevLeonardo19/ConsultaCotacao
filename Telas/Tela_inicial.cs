using Cotação.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cotação
{
    public partial class Tela_inicial : Form
    {
        public Tela_inicial()
        {
            InitializeComponent();
        }

        private void dolarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dolar dolar = new Dolar();
            dolar.Show();
        }

        private void conversãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conversao conversao = new Conversao();
            conversao.Show();
        }
    }
}
