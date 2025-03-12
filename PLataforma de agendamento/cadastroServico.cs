using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLataforma_de_agendamento
{
    public partial class cadastro_de_serviço : Form
    {
        public cadastro_de_serviço()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void buttonStatusServico_Click(object sender, EventArgs e)
        {
            // Defina sua string de conexão com o banco 
            string conexaoString = "Server=localhost; Port=3306; Database=db_plataformaagendamento; Uid=root; Pwd=;";

            // Defina a inserção de registro no Bd
            string query = "INSERT INTO tb_cad_servicos(servico, tempo, categoria, valor, nome_profissional, previsao_retorno, descricao, foto_servico1, foto_servico2, foto_servico3) VALUES " + "(@servico, @tempo, @categoria, @valor, @nome_profissional, @previsao_retorno, @descricao, @foto_servico1, @foto_servico2, @foto_servico3)";

            // Crie conexao com o Bd
            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    //Abre a conexao
                    conexao.Open();

                    //Crie o comando SQL
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        //adicionar os parametros com os valores do TextBox
                        comando.Parameters.AddWithValue("@servico", textBoxServico.Text);
                        comando.Parameters.AddWithValue("@tempo", comboBoxTempo.Text);
                        comando.Parameters.AddWithValue("@categoria", comboBoxCategoria.Text);
                        comando.Parameters.AddWithValue("@valor", maskedTextBoxValor.Text);
                        comando.Parameters.AddWithValue("@nome_profissional", textBoxProfissional.Text);
                        comando.Parameters.AddWithValue("@previsao_retorno", textBoxPrevRetorno.Text);
                        comando.Parameters.AddWithValue("@descricao", richTextBoxDescricao.Text);
                        comando.Parameters.AddWithValue("@foto_servico1", pictureBoxFotoServico1.Text);
                        comando.Parameters.AddWithValue("@foto_servico2", pictureBoxFotoServico2.Text);
                        comando.Parameters.AddWithValue("@foto_servico3", pictureBoxFotoServico3.Text);


                        //Executeo comando de inserção
                        comando.ExecuteNonQuery();

                        MessageBox.Show("Dados inseridos com sucesso!");

                        textBoxServico.Text = "";
                        comboBoxTempo.Text = "";
                        comboBoxCategoria.Text = "";
                        maskedTextBoxValor.Text = "";
                        textBoxProfissional.Text = "";
                        textBoxPrevRetorno.Text = "";
                        richTextBoxDescricao.Text = "";
                        pictureBoxFotoServico1.Text = "";
                        pictureBoxFotoServico2.Text = "";
                        pictureBoxFotoServico3.Text = "";
                        textBoxServico.Focus();

                    }

                }
                catch (Exception ex)
                {
                    // em caso de erro, exiba a mensagem do erro 
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }

        }

        private void ButtonFotoServico1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*gif;*bmp;";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pictureBoxFotoServico1.Image = Image.FromFile(openFileDialog1.FileName);
            pictureBoxFotoServico1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void buttonFotoServico2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*gif;*bmp;";
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
                pictureBoxFotoServico2.Image = Image.FromFile(openFileDialog2.FileName);
            pictureBoxFotoServico2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void buttonFotoServico3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog3 = new OpenFileDialog();
            openFileDialog3.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*gif;*bmp;";
            if (openFileDialog3.ShowDialog() == DialogResult.OK)
                pictureBoxFotoServico3.Image = Image.FromFile(openFileDialog3.FileName);
            pictureBoxFotoServico3.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void comboBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
