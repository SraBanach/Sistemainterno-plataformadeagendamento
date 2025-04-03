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
    public partial class agenda : Form
    {
        public agenda()
        {
            InitializeComponent();
        }

        private void buttonListarAgenda_Click(object sender, EventArgs e)
        {
            // Defina sua string de conexão com o banco 
            string conectionString = "Server=localhost; Port=3306; Database=db_plataformaagendamento; Uid=root; Pwd=;Convert Zero Datetime=True";

            try
            {       //Cria uma conexao com o banco de dados MySql
                using (MySqlConnection consulta = new MySqlConnection(conectionString))
                {
                    //Abre conexao
                    consulta.Open();

                    //consulta SQL  para selecionar clientes
                    string query = "SELECT id, profissional, servico, valor, horario, data_agendamento, observacoes FROM tb_agendamento";

                    //Cria o comando MySql
                    using (MySqlCommand cmd = new MySqlCommand(query, consulta))
                    {
                        //Executa a consulta e obtem os resultados
                        MySqlDataReader reader = cmd.ExecuteReader();

                        //Cria uma lista para armazenar os registros 
                        DataTable dadosProdutos = new DataTable();
                        dadosProdutos.Load(reader);

                        //Atribui a tabela de dados ao DataGridWiew
                        dataGridViewAgenda.DataSource = dadosProdutos;


                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar a agenda:" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewAgenda.SelectedRows.Count > 0)
            {
                //pega ID do carro da linha selecionada 
                int Id = Convert.ToInt32(dataGridViewAgenda.SelectedRows[0].Cells["Id"].Value);

                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este agendamento?", "Confirmar Exclusão", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string connectionString = "Server=localhost; Port=3306; Database=db_plataformaagendamento; Uid=root; Pwd=; Convert Zero Datetime=True ";

                    try
                    {
                        //Cria uma conexão com o banco de dados Mysql
                        using (MySqlConnection consulta = new MySqlConnection(connectionString))
                        {
                            //abre a conexão 
                            consulta.Open();
                            //consulta SQL para selecionar os carros
                            string listagem = "DELETE FROM tb_agendamento WHERE Id = @Id";

                            using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                            {
                                cmd.Parameters.AddWithValue("Id", Id);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Agendamento excluido com sucesso!");
                                }
                                else
                                {
                                    MessageBox.Show("Falha ao excluir o Agendamento");
                                }
                            }
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao listar os carros:" + ex.Message);
                    }

                }

                else
                {
                    MessageBox.Show("Por favor, selecione um carro para excluir!");
                }
            }
        }
    }
}
     
    

