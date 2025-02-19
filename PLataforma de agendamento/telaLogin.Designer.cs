namespace PLataforma_de_agendamento
{
    partial class telaLogin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabelEsqueceuSenha = new System.Windows.Forms.LinkLabel();
            this.linkLabelMostrarSenha = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabelMostrarSenha);
            this.groupBox1.Controls.Add(this.linkLabelEsqueceuSenha);
            this.groupBox1.Controls.Add(this.buttonEntrar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxSenha);
            this.groupBox1.Controls.Add(this.textBoxUsuario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(132, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 301);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonEntrar.Location = new System.Drawing.Point(177, 245);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(140, 28);
            this.buttonEntrar.TabIndex = 19;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(134, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Usuário:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(142, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Senha:";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(198, 181);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(139, 20);
            this.textBoxSenha.TabIndex = 4;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(198, 117);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(139, 20);
            this.textBoxUsuario.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Acesso ao sistema";
            // 
            // linkLabelEsqueceuSenha
            // 
            this.linkLabelEsqueceuSenha.AutoSize = true;
            this.linkLabelEsqueceuSenha.Location = new System.Drawing.Point(192, 276);
            this.linkLabelEsqueceuSenha.Name = "linkLabelEsqueceuSenha";
            this.linkLabelEsqueceuSenha.Size = new System.Drawing.Size(113, 13);
            this.linkLabelEsqueceuSenha.TabIndex = 20;
            this.linkLabelEsqueceuSenha.TabStop = true;
            this.linkLabelEsqueceuSenha.Text = "Esqueceu sua senha?";
            // 
            // linkLabelMostrarSenha
            // 
            this.linkLabelMostrarSenha.AutoSize = true;
            this.linkLabelMostrarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelMostrarSenha.Location = new System.Drawing.Point(370, 188);
            this.linkLabelMostrarSenha.Name = "linkLabelMostrarSenha";
            this.linkLabelMostrarSenha.Size = new System.Drawing.Size(76, 13);
            this.linkLabelMostrarSenha.TabIndex = 21;
            this.linkLabelMostrarSenha.TabStop = true;
            this.linkLabelMostrarSenha.Text = "Mostrar Senha";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "tela_login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelEsqueceuSenha;
        private System.Windows.Forms.LinkLabel linkLabelMostrarSenha;
    }
}