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

namespace PLataforma_de_agendamento
{
    public partial class bancoClientes : Form
    {
        public bancoClientes()
        {
            InitializeComponent();
        }

        private void buttonListarClientes_Click(object sender, EventArgs e)
        {
            // Defina sua string de conexão com o banco 
            string conectionString = "Server=82.180.153.103;Port=3306;Database=u667494514_db_plataforma;Uid=u667494514_kenya;Pwd=Hades.4289;Convert Zero Datetime=True;";

            try
            {       //Cria uma conexao com o banco de dados MySql
                using (MySqlConnection consulta = new MySqlConnection(conectionString))
                {
                    //Abre conexao
                    consulta.Open();

                    //consulta SQL  para selecionar clientes
                    string query = "SELECT id_usuario, nome, telefone, cpf FROM tb_cad_usuario";

                    //Cria o comando MySql
                    using (MySqlCommand cmd = new MySqlCommand(query, consulta))
                    {
                        //Executa a consulta e obtem os resultados
                        MySqlDataReader reader = cmd.ExecuteReader();

                        //Cria uma lista para armazenar os registros 
                        DataTable dadosClientes = new DataTable();
                        dadosClientes.Load(reader);

                        //Atribui a tabela de dados ao DataGridWiew
                        dataGridViewListarClientes.DataSource = dadosClientes;


                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os clientes:" + ex.Message);
            }
        }

        private void buttonExcluirClientes_Click(object sender, EventArgs e)
        {

            if (dataGridViewListarClientes.SelectedRows.Count > 0)
            {
                //pega ID do carro da linha selecionada 
                int id_Clientes = Convert.ToInt32(dataGridViewListarClientes.SelectedRows[0].Cells["id_usuario"].Value);

                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este cliente?", "Confirmar Exclusão", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string connectionString = "Server=82.180.153.103;Port=3306;Database=u667494514_db_plataforma;Uid=u667494514_kenya;Pwd=Hades.4289;Convert Zero Datetime=True;";
                    try
                    {
                        //Cria uma conexão com o banco de dados Mysql
                        using (MySqlConnection consulta = new MySqlConnection(connectionString))
                        {
                            //abre a conexão 
                            consulta.Open();
                            //consulta SQL para selecionar os clientes
                            string listagem = "DELETE FROM tb_cad_usuario WHERE id_usuario = @id_usuario";

                            using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                            {
                                cmd.Parameters.AddWithValue("id_usuario", id_Clientes);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Cliente excluido com sucesso!");
                                }
                                else
                                {
                                    MessageBox.Show("Falha ao excluir o cliente");
                                }
                            }
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao listar os clientes:" + ex.Message);
                    }

                }

                else
                {
                    MessageBox.Show("Por favor, selecione um cliente para excluir!");
                }
            }
        }
    }
    
}
