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
    public partial class cadastroEmpresa : Form
    {
        public cadastroEmpresa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void buttonStatusServico_Click(object sender, EventArgs e)
        {
            // Defina sua string de conexão com o banco 
            string conexaoString = "Server=localhost; Port=3306; Database=db_plataformaagendamento; Uid=root; Pwd=;";

            // Defina a inserção de registro no Bd
            string query = "INSERT INTO tb_cad_empresas(razaoSocial, nomeFantasia, cnpj, servicos, horario, telefone, nomeContato, cep, estado, cidade, rua, numero, complemento, sobreEmpresa, fotoEmpresa1, fotoEmpresa2, fotoEmpresa3, fotoLogo) VALUES " + "(@razaoSocial, @nomeFantasia, @cnpj, @servicos, @horario, @telefone, @nomeContato, @cep, @estado, @cidade, @rua, @numero, @complemento, @sobreEmpresa, @fotoEmpresa1, @fotoEmpresa2, @fotoEmpresa3, @fotoLogo)";

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
                        comando.Parameters.AddWithValue("@razaoSocial", textBoxRazaoSocial.Text);
                        comando.Parameters.AddWithValue("@nomeFantasia", textBoxNomeFantasia.Text);
                        comando.Parameters.AddWithValue("@cnpj", maskedTextBoxCnpj.Text);
                        comando.Parameters.AddWithValue("@servicos", checkedListBox1.Text);
                        comando.Parameters.AddWithValue("@telefone", maskedTextBoxTelefone.Text);
                        comando.Parameters.AddWithValue("@nomeContato", textBoxNomeContato.Text);
                        comando.Parameters.AddWithValue("@cep", maskedTextBoxCep.Text);
                        comando.Parameters.AddWithValue("@estado", comboBoxEstado.Text);
                        comando.Parameters.AddWithValue("@cidade", textBoxCidade.Text);
                        comando.Parameters.AddWithValue("@rua", textBoxRua.Text);
                        comando.Parameters.AddWithValue("@numero", textBoxNumero.Text);
                        comando.Parameters.AddWithValue("@complemento", textBoxComplemento.Text);

                        comando.Parameters.AddWithValue("@fotoEmpresa1", pictureBoxFotoEmpresa1.Text);
                        comando.Parameters.AddWithValue("@fotoEmpresa2", pictureBoxFotoEmpresa2.Text);
                        comando.Parameters.AddWithValue("@fotoEmpresa3", pictureBoxFotoEmpresa3.Text);
                        comando.Parameters.AddWithValue("@fotoLogo", pictureBoxFotoLogo.Text);


                        //Executeo comando de inserção
                        comando.ExecuteNonQuery();

                        MessageBox.Show("Dados inseridos com sucesso!");

                        textBoxRazaoSocial.Text = "";
                        textBoxNomeFantasia.Text = "";
                        maskedTextBoxCnpj.Text = "";
                        checkedListBox1.Text = "";
                        maskedTextBoxTelefone.Text = "";
                        textBoxNomeContato.Text = "";
                        maskedTextBoxCep.Text = "";
                        comboBoxEstado.Text = "";
                        textBoxCidade.Text = "";
                        textBoxRua.Text = "";
                        textBoxNumero.Text = "";
                        textBoxComplemento.Text = "";

                        pictureBoxFotoEmpresa1.Text = "";
                        pictureBoxFotoEmpresa2.Text = "";
                        pictureBoxFotoEmpresa3.Text = "";
                        textBoxRazaoSocial.Focus();

                    }

                }
                catch (Exception ex)
                {
                    // em caso de erro, exiba a mensagem do erro 
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void buttonFotoEmpresa1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*gif;*bmp;";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pictureBoxFotoEmpresa1.Image = Image.FromFile(openFileDialog1.FileName);
            pictureBoxFotoEmpresa1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void buttonFotoEmpresa2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*gif;*bmp;";
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
                pictureBoxFotoEmpresa2.Image = Image.FromFile(openFileDialog2.FileName);
            pictureBoxFotoEmpresa2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void buttonFotoEmpresa3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog3 = new OpenFileDialog();
            openFileDialog3.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*gif;*bmp;";
            if (openFileDialog3.ShowDialog() == DialogResult.OK)
                pictureBoxFotoEmpresa3.Image = Image.FromFile(openFileDialog3.FileName);
            pictureBoxFotoEmpresa3.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void buttonFotoEmpresa4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog4 = new OpenFileDialog();
            openFileDialog4.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*gif;*bmp;";
            if (openFileDialog4.ShowDialog() == DialogResult.OK)
                pictureBoxFotoLogo.Image = Image.FromFile(openFileDialog4.FileName);
            pictureBoxFotoLogo.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void textBoxHorario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
