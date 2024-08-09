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
    public partial class Frm_cadastrarVeiculos : Form
    {
        Connection conexao = new Connection();

        public Frm_cadastrarVeiculos()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            string modelo = txt_modelo.Text;
            string placa = txt_placa.Text;
            string cor = txt_cor.Text;
            conexao.conexaoBD();
            conexao.cadastrarVeiculos(modelo, placa, cor);

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
