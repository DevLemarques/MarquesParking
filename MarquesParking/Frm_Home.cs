using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarquesParking
{
    public partial class Frm_Home : Form
    {
        Connection connect = new Connection();
        DateTime time;

        public Frm_Home()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void icon_logout_Click(object sender, EventArgs e)
        {
          

            this.Close();
        }

        private void btn_cadastrarVeiculo_Click(object sender, EventArgs e)
        {
            Frm_cadastrarVeiculos frm_CadastrarVeiculos = new Frm_cadastrarVeiculos();
            frm_CadastrarVeiculos.ShowDialog();
        }

        private void btn_removerVeiculo_Click(object sender, EventArgs e)
        {
            Frm_RemoverVeiculos frm_RemoverVeiculos = new Frm_RemoverVeiculos();
            frm_RemoverVeiculos.ShowDialog();
        }

        private void btn_listarVeiculo_Click(object sender, EventArgs e)
        {
            Frm_ListarVeiculos frm_ListarVeiculos = new Frm_ListarVeiculos();
            frm_ListarVeiculos.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = DateTime.Now;
            lb_dataDinamic.Text = (" Data e Hora: " + time.ToUniversalTime());
        }
    }
}
