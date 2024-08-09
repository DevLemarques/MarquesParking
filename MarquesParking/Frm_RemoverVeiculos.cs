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
    public partial class Frm_RemoverVeiculos : Form
    {
        Connection conexao =new Connection();

        public Frm_RemoverVeiculos()
        {
            InitializeComponent();
        }

        private void txt_placa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            string placa = txt_placa.Text;
            conexao.conexaoBD();
            conexao.removerVeiculo(placa);
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
