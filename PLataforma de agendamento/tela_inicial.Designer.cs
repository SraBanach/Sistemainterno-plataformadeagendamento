namespace PLataforma_de_agendamento
{
    partial class tela_inicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonBancoClientes = new System.Windows.Forms.Button();
            this.buttonCadastroProfissionais = new System.Windows.Forms.Button();
            this.buttonMinhaAgenda = new System.Windows.Forms.Button();
            this.buttonCadastroServico = new System.Windows.Forms.Button();
            this.buttonCadastroSalao = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridViewCalendario = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalendario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plataforma de agendamento";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewCalendario);
            this.groupBox1.Controls.Add(this.buttonBancoClientes);
            this.groupBox1.Controls.Add(this.buttonCadastroProfissionais);
            this.groupBox1.Controls.Add(this.buttonMinhaAgenda);
            this.groupBox1.Controls.Add(this.buttonCadastroServico);
            this.groupBox1.Controls.Add(this.buttonCadastroSalao);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // buttonBancoClientes
            // 
            this.buttonBancoClientes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBancoClientes.Location = new System.Drawing.Point(5, 375);
            this.buttonBancoClientes.Name = "buttonBancoClientes";
            this.buttonBancoClientes.Size = new System.Drawing.Size(138, 33);
            this.buttonBancoClientes.TabIndex = 6;
            this.buttonBancoClientes.Text = "Banco de clientes";
            this.buttonBancoClientes.UseVisualStyleBackColor = false;
            // 
            // buttonCadastroProfissionais
            // 
            this.buttonCadastroProfissionais.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCadastroProfissionais.Location = new System.Drawing.Point(6, 335);
            this.buttonCadastroProfissionais.Name = "buttonCadastroProfissionais";
            this.buttonCadastroProfissionais.Size = new System.Drawing.Size(137, 34);
            this.buttonCadastroProfissionais.TabIndex = 5;
            this.buttonCadastroProfissionais.Text = "Cadastro de profissionais";
            this.buttonCadastroProfissionais.UseVisualStyleBackColor = false;
            // 
            // buttonMinhaAgenda
            // 
            this.buttonMinhaAgenda.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMinhaAgenda.Location = new System.Drawing.Point(6, 298);
            this.buttonMinhaAgenda.Name = "buttonMinhaAgenda";
            this.buttonMinhaAgenda.Size = new System.Drawing.Size(137, 31);
            this.buttonMinhaAgenda.TabIndex = 4;
            this.buttonMinhaAgenda.Text = "Minha agenda";
            this.buttonMinhaAgenda.UseVisualStyleBackColor = false;
            // 
            // buttonCadastroServico
            // 
            this.buttonCadastroServico.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCadastroServico.Location = new System.Drawing.Point(6, 259);
            this.buttonCadastroServico.Name = "buttonCadastroServico";
            this.buttonCadastroServico.Size = new System.Drawing.Size(137, 33);
            this.buttonCadastroServico.TabIndex = 3;
            this.buttonCadastroServico.Text = "Cadastro de serviço";
            this.buttonCadastroServico.UseVisualStyleBackColor = false;
            // 
            // buttonCadastroSalao
            // 
            this.buttonCadastroSalao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCadastroSalao.Location = new System.Drawing.Point(6, 220);
            this.buttonCadastroSalao.Name = "buttonCadastroSalao";
            this.buttonCadastroSalao.Size = new System.Drawing.Size(137, 33);
            this.buttonCadastroSalao.TabIndex = 2;
            this.buttonCadastroSalao.Text = "Cadastro do salão";
            this.buttonCadastroSalao.UseVisualStyleBackColor = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(6, 46);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // dataGridViewCalendario
            // 
            this.dataGridViewCalendario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCalendario.Location = new System.Drawing.Point(245, 45);
            this.dataGridViewCalendario.Name = "dataGridViewCalendario";
            this.dataGridViewCalendario.Size = new System.Drawing.Size(525, 375);
            this.dataGridViewCalendario.TabIndex = 7;
            // 
            // tela_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "tela_inicial";
            this.Text = "tela_inicial";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalendario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button buttonBancoClientes;
        private System.Windows.Forms.Button buttonCadastroProfissionais;
        private System.Windows.Forms.Button buttonMinhaAgenda;
        private System.Windows.Forms.Button buttonCadastroServico;
        private System.Windows.Forms.Button buttonCadastroSalao;
        private System.Windows.Forms.DataGridView dataGridViewCalendario;
    }
}