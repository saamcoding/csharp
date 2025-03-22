using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aulaTelas
{
    public partial class TelaMenuPrincipal : Form
    {
        public TelaMenuPrincipal()
        {
            InitializeComponent();
            this.FormClosing += AppClose;
        }

        private void AppClose(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Voce deseja realmente sair da aplicacao?", "Sair do programa", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            } else
            {
                e.Cancel = true;
            }
                
        }

        private void TelaMenuPrincipal_Load(object sender, EventArgs e)
        {
            
        }
    }
}
