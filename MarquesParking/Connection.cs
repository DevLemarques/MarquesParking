using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarquesParking
{
    public class Connection
    {
        private MySqlConnection connection;
        private string adressDataBase;

        public void conexaoBD()
        {
            try
            {
                this.adressDataBase = "server=localhost;uid=root;database=marquezparking";
                connection = new MySqlConnection(adressDataBase);
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void fecharConexao()
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public void cadastrarVeiculos(string modelo, string placa, string cor)
        {
            try
            {
                conexaoBD();

                var command = new MySqlCommand("INSERT INTO veiculos (modelo, placa, cor, cadastrado_em, atualizado_em) " +
                                        "VALUES (@modelo, @placa, @cor, NOW(), NOW())", connection);

                command.Parameters.AddWithValue("@modelo", modelo);
                command.Parameters.AddWithValue("@placa", placa);
                command.Parameters.AddWithValue("@cor", cor);

                
                int linhasAfetadas = command.ExecuteNonQuery();

                
                MessageBox.Show($"{linhasAfetadas} veículo(s) inserido(s) com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }

            finally
            {

            }

        }


        public void removerVeiculo(string placa)
        {
            try
            {
                conexaoBD();

                var command = new MySqlCommand("DELETE FROM veiculos WHERE placa = @placa", connection);
                command.Parameters.AddWithValue("@placa", placa);

                int linhasAfetadas = command.ExecuteNonQuery();
                MessageBox.Show($"{linhasAfetadas} veículo(s) removido(s) com sucesso!");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable listaVeiculos()
        {
            DataTable dataTable = new DataTable(); 

            try
            {
                conexaoBD();
                var command = new MySqlCommand("SELECT * FROM veiculos", connection);
                var reader = command.ExecuteReader();

                
                dataTable.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                
            }

            return dataTable; 
        }
    }
}
