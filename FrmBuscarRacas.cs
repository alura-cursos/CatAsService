using CatAsService.APIService;
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
        private APIService.CatAsService ApiCatAsService;         

        public FrmBuscarRacas()
        {            
            InitializeComponent();
            ApiCatAsService = new APIService.CatAsService();
        }

        private void FrmBuscarRacas_Load(object sender, EventArgs e)
        {
            //Para combobox começar com a opção de "Selecione uma Raça"
            cbListaRacas.SelectedIndex = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            //Se o usuário selecionou uma raça diferente do "Selecione uma Raça"
            if (cbListaRacas.SelectedIndex > 0)
            {
                string idRaca = cbListaRacas.Text;
                CarregaResultadoTela(ApiCatAsService.GetCaracteristicasPorID(idRaca));
            }
            else
            {
                MessageBox.Show("Selecione uma Raça para Buscar");
                LimpaResultados();
            }
        }

        private void CarregaResultadoTela(CatModel Resultado) 
        {
            lblDescricao.Text = Resultado.description;
            lblOrigem.Text = Resultado.origin;
            lblTemperamento.Text = Resultado.temperament;
        }

        private void LimpaResultados()
        {
            lblDescricao.Text = "Resultado";
            lblOrigem.Text = "Resultado";
            lblTemperamento.Text = "Resultado";
        }

        private void btnFavoritar_Click(object sender, EventArgs e)
        {

        }
    }
}
