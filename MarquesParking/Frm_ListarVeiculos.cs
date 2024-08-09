using MySqlX.XDevAPI.Relational;
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
    public partial class Frm_ListarVeiculos : Form
    {
        Connection conexao = new Connection();
        
        public Frm_ListarVeiculos()
        {
            InitializeComponent();
        }

        private void tb_veiculo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void Frm_ListarVeiculos_Load(object sender, EventArgs e)
        {
            CarregarVeiculos();
        }


        private void CarregarVeiculos()
        {
            DataTable veiculosTable = conexao.listaVeiculos(); 

            tb_veiculos.DataSource = veiculosTable; 
        }

        private void btn_teste_Click(object sender, EventArgs e)
        {
            CarregarVeiculos();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
