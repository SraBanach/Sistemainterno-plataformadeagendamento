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
    public partial class telaLogin : Form
    {

        bool VerSenhaTxt = false;
        private string usuarioCorreto = "kenya";
        private string senhaCorreta = "123";

        public telaLogin()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabelMostrarSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (VerSenhaTxt == false)
            {
                textBoxSenha.PasswordChar = '\0';
                VerSenhaTxt = true;
                linkLabelMostrarSenha.Text = "Ocultar Senha";
            }
            else
            {
                textBoxSenha.PasswordChar = '*';
                VerSenhaTxt = false;
                linkLabelMostrarSenha.Text = "Mostrar Senha";
            }
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text;
            string senha = textBoxSenha.Text;

            if (usuario == usuarioCorreto && senha == senhaCorreta)
            {
                labelMenssagem.Text = "Login bem-sucedido";
                labelMenssagem.ForeColor = Color.Green;
                tela_inicial form = new tela_inicial();
                form.ShowDialog();
            }
            else
            {
                labelMenssagem.Text = "Usuário ou senha Invalida";
                labelMenssagem.ForeColor = Color.Red;
                textBoxUsuario.Text = "";
                textBoxSenha.Text = "";
                textBoxUsuario.Focus();
            }
        }
    }
}
