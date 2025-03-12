using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PLataforma_de_agendamento
{
    public partial class CadastroProfissional : Form
    {

        private bool ValidarCpf(string cpf)
        {
            // Remove qualquer caractere não numérico
            cpf = Regex.Replace(cpf, @"[^\d]", "");

            // Verifica se tem 11 dígitos
            if (cpf.Length != 11)
                return false;

            // Verifica se o CPF é uma sequência de números iguais (ex.: 111.111.111-11)
            if (new string(cpf[0], 11) == cpf)
                return false;

            // Calculando o primeiro dígito verificador
            int soma = 0;
            int peso = 10;
            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * peso--;
            }

            int resto = soma % 11;
            int digito1 = resto < 2 ? 0 : 11 - resto;
            if (digito1 != int.Parse(cpf[9].ToString()))
                return false;

            // Calculando o segundo dígito verificador
            soma = 0;
            peso = 11;
            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * peso--;
            }

            resto = soma % 11;
            int digito2 = resto < 2 ? 0 : 11 - resto;
            return digito2 == int.Parse(cpf[10].ToString());
        }
        public CadastroProfissional()
        {
            InitializeComponent();
        }

        private void CadastroProfissional_Load(object sender, EventArgs e)
        {

        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            string cpf = maskedTextBoxCPF.Text;

            if (ValidarCpf(cpf))
            {
                labelAlertCpf.Text = "CPF VÁLIDO";
                labelAlertCpf.ForeColor = Color.Green;
            }
            else
            {

                labelAlertCpf.Text = "CPF INVÁLIDO";
                labelAlertCpf.ForeColor = Color.Red;
                maskedTextBoxCPF.Text = "";
                maskedTextBoxCPF.Focus();
            }

            // Defina sua string de conexão com o banco 
            string conexaoString = "Server=localhost; Port=3306; Database=db_plataformaagendamento; Uid=root; Pwd=;";

            // Defina a inserção de registro no Bd
            string query = "INSERT INTO tb_cad_profissional(nome_profissional, dat_nasc, cpf, telefone, area, certificado, anotacoes, foto_profissional1, foto_profissional2, foto_profissional3) VALUES " + "(@nome_profissional, @dat_nasc," +
                " @cpf, @telefone, @area, @certificado, @anotacoes, @foto_profissional1, @foto_profissional2, @foto_profissional3)";

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
                        comando.Parameters.AddWithValue("@nome_profissional", textBoxNome.Text);
                        comando.Parameters.AddWithValue("@dat_nasc", maskedTextBoxDatNasc.Text);
                        comando.Parameters.AddWithValue("@cpf", maskedTextBoxCPF.Text);
                        comando.Parameters.AddWithValue("@telefone", maskedTextBoxTel.Text);
                        comando.Parameters.AddWithValue("@area", textBoxArea.Text);
                        comando.Parameters.AddWithValue("@certificado", textBoxCertificado.Text);
                        comando.Parameters.AddWithValue("@anotacoes", richTextBoxAnotacoes.Text);
                        comando.Parameters.AddWithValue("@foto_profissional1", pictureBoxFotoProfissional1.Text);
                        comando.Parameters.AddWithValue("@foto_profissional2", pictureBoxFotoProfissional2.Text);
                        comando.Parameters.AddWithValue("@foto_profissional3", pictureBoxFotoProfissional3.Text);


                        //Executeo comando de inserção
                        comando.ExecuteNonQuery();

                        MessageBox.Show("Dados inseridos com sucesso!");

                        textBoxNome.Text = "";
                        maskedTextBoxDatNasc.Text = "";
                        maskedTextBoxCPF.Text = "";
                        maskedTextBoxTel.Text = "";
                        textBoxArea.Text = "";
                        textBoxCertificado.Text = "";
                        richTextBoxAnotacoes.Text = "";
                        pictureBoxFotoProfissional1.Text = "";
                        pictureBoxFotoProfissional2.Text = "";
                        pictureBoxFotoProfissional3.Text = "";
                        textBoxNome.Focus();

                    }

                }
                catch (Exception ex)
                {
                    // em caso de erro, exiba a mensagem do erro 
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
    }

        private void buttonAdicionarFoto1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*gif;*bmp;";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pictureBoxFotoProfissional1.Image =Image.FromFile(openFileDialog1.FileName);
            pictureBoxFotoProfissional1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void buttonAdicionarFoto2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*gif;*bmp;";
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
                pictureBoxFotoProfissional2.Image = Image.FromFile(openFileDialog2.FileName);
            pictureBoxFotoProfissional2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void buttonAdicionarFoto3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog3 = new OpenFileDialog();
            openFileDialog3.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*gif;*bmp;";
            if (openFileDialog3.ShowDialog() == DialogResult.OK)
                pictureBoxFotoProfissional3.Image = Image.FromFile(openFileDialog3.FileName);
            pictureBoxFotoProfissional3.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
