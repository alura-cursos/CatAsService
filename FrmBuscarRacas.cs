using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CatAsService
{
    public partial class FrmBuscarRacas : Form
    {
        public FrmBuscarRacas()
        {
            
            InitializeComponent();
        }

        private void FrmBuscarRacas_Load(object sender, EventArgs e)
        {
            //Para combobox começar com a opção de "Selecione uma Raça"
            cbListaRacas.SelectedIndex = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnFavoritar_Click(object sender, EventArgs e)
        {

        }
    }
}
