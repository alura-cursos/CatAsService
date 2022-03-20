using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CatAsService
{
    public partial class FrmTelaInicial : Form
    {
        public FrmTelaInicial()
        {
            InitializeComponent();
        }

        private void buscarRaçasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscarRacas frmBuscaRacas = new FrmBuscarRacas();
            frmBuscaRacas.ShowDialog();
        }

        private void meusFavoritosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelatorioFavoritos frmBuscarFavoritos = new FrmRelatorioFavoritos();
            frmBuscarFavoritos.ShowDialog();
        }
    }
}
