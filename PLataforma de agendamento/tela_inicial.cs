﻿using System;
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
    public partial class tela_inicial : Form
    {
        public tela_inicial()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonCadastroSalao_Click(object sender, EventArgs e)
        {
            cadastroEmpresa form = new cadastroEmpresa();
            form.ShowDialog(); 
        }

        private void buttonCadastroServico_Click(object sender, EventArgs e)
        {
            cadastro_de_serviço form = new cadastro_de_serviço();
            form.ShowDialog();
        }

        private void buttonCadastroProfissionais_Click(object sender, EventArgs e)
        {
            CadastroProfissional form = new CadastroProfissional();
            form.ShowDialog();
        }

        private void buttonBancoClientes_Click(object sender, EventArgs e)
        {
            bancoClientes form = new bancoClientes();
            form.ShowDialog();
        }
    }
}
