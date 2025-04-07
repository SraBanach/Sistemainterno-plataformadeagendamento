namespace PLataforma_de_agendamento
{
    partial class cadastro_de_serviço
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
            this.buttonFotoServico3 = new System.Windows.Forms.Button();
            this.buttonFotoServico2 = new System.Windows.Forms.Button();
            this.ButtonFotoServico1 = new System.Windows.Forms.Button();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxValor = new System.Windows.Forms.MaskedTextBox();
            this.richTextBoxDescricao = new System.Windows.Forms.RichTextBox();
            this.pictureBoxFotoServico3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxFotoServico2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxFotoServico1 = new System.Windows.Forms.PictureBox();
            this.buttonStatusServico = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxServico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoServico3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoServico2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoServico1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonFotoServico3);
            this.groupBox1.Controls.Add(this.buttonFotoServico2);
            this.groupBox1.Controls.Add(this.ButtonFotoServico1);
            this.groupBox1.Controls.Add(this.comboBoxCategoria);
            this.groupBox1.Controls.Add(this.maskedTextBoxValor);
            this.groupBox1.Controls.Add(this.richTextBoxDescricao);
            this.groupBox1.Controls.Add(this.pictureBoxFotoServico3);
            this.groupBox1.Controls.Add(this.pictureBoxFotoServico2);
            this.groupBox1.Controls.Add(this.pictureBoxFotoServico1);
            this.groupBox1.Controls.Add(this.buttonStatusServico);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxServico);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 437);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // buttonFotoServico3
            // 
            this.buttonFotoServico3.Location = new System.Drawing.Point(576, 386);
            this.buttonFotoServico3.Name = "buttonFotoServico3";
            this.buttonFotoServico3.Size = new System.Drawing.Size(91, 45);
            this.buttonFotoServico3.TabIndex = 29;
            this.buttonFotoServico3.Text = "Adicionar Foto";
            this.buttonFotoServico3.UseVisualStyleBackColor = true;
            this.buttonFotoServico3.Click += new System.EventHandler(this.buttonFotoServico3_Click);
            // 
            // buttonFotoServico2
            // 
            this.buttonFotoServico2.Location = new System.Drawing.Point(576, 252);
            this.buttonFotoServico2.Name = "buttonFotoServico2";
            this.buttonFotoServico2.Size = new System.Drawing.Size(91, 45);
            this.buttonFotoServico2.TabIndex = 28;
            this.buttonFotoServico2.Text = "Adicionar Foto";
            this.buttonFotoServico2.UseVisualStyleBackColor = true;
            this.buttonFotoServico2.Click += new System.EventHandler(this.buttonFotoServico2_Click);
            // 
            // ButtonFotoServico1
            // 
            this.ButtonFotoServico1.Location = new System.Drawing.Point(576, 118);
            this.ButtonFotoServico1.Name = "ButtonFotoServico1";
            this.ButtonFotoServico1.Size = new System.Drawing.Size(91, 45);
            this.ButtonFotoServico1.TabIndex = 27;
            this.ButtonFotoServico1.Text = "Adicionar Foto";
            this.ButtonFotoServico1.UseVisualStyleBackColor = true;
            this.ButtonFotoServico1.Click += new System.EventHandler(this.ButtonFotoServico1_Click);
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Items.AddRange(new object[] {
            "Manicure ",
            "Pedicure ",
            "Depilação ",
            "Barbearia",
            "Cabelo ",
            "Maquiagem ",
            "Sobrancelhas ",
            "Spa ",
            "Massagem ",
            "Bronzeamento"});
            this.comboBoxCategoria.Location = new System.Drawing.Point(9, 176);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(139, 24);
            this.comboBoxCategoria.TabIndex = 26;
            this.comboBoxCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategoria_SelectedIndexChanged);
            // 
            // maskedTextBoxValor
            // 
            this.maskedTextBoxValor.Location = new System.Drawing.Point(9, 260);
            this.maskedTextBoxValor.Mask = "$000,00";
            this.maskedTextBoxValor.Name = "maskedTextBoxValor";
            this.maskedTextBoxValor.Size = new System.Drawing.Size(136, 22);
            this.maskedTextBoxValor.TabIndex = 24;
            // 
            // richTextBoxDescricao
            // 
            this.richTextBoxDescricao.Location = new System.Drawing.Point(9, 343);
            this.richTextBoxDescricao.Name = "richTextBoxDescricao";
            this.richTextBoxDescricao.Size = new System.Drawing.Size(433, 57);
            this.richTextBoxDescricao.TabIndex = 23;
            this.richTextBoxDescricao.Text = "";
            // 
            // pictureBoxFotoServico3
            // 
            this.pictureBoxFotoServico3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxFotoServico3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFotoServico3.Location = new System.Drawing.Point(552, 324);
            this.pictureBoxFotoServico3.Name = "pictureBoxFotoServico3";
            this.pictureBoxFotoServico3.Size = new System.Drawing.Size(142, 84);
            this.pictureBoxFotoServico3.TabIndex = 22;
            this.pictureBoxFotoServico3.TabStop = false;
            // 
            // pictureBoxFotoServico2
            // 
            this.pictureBoxFotoServico2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxFotoServico2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFotoServico2.Location = new System.Drawing.Point(552, 188);
            this.pictureBoxFotoServico2.Name = "pictureBoxFotoServico2";
            this.pictureBoxFotoServico2.Size = new System.Drawing.Size(142, 84);
            this.pictureBoxFotoServico2.TabIndex = 21;
            this.pictureBoxFotoServico2.TabStop = false;
            // 
            // pictureBoxFotoServico1
            // 
            this.pictureBoxFotoServico1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxFotoServico1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFotoServico1.Location = new System.Drawing.Point(552, 50);
            this.pictureBoxFotoServico1.Name = "pictureBoxFotoServico1";
            this.pictureBoxFotoServico1.Size = new System.Drawing.Size(142, 84);
            this.pictureBoxFotoServico1.TabIndex = 20;
            this.pictureBoxFotoServico1.TabStop = false;
            // 
            // buttonStatusServico
            // 
            this.buttonStatusServico.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonStatusServico.Location = new System.Drawing.Point(153, 403);
            this.buttonStatusServico.Name = "buttonStatusServico";
            this.buttonStatusServico.Size = new System.Drawing.Size(140, 28);
            this.buttonStatusServico.TabIndex = 19;
            this.buttonStatusServico.Text = "Status de serviço";
            this.buttonStatusServico.UseVisualStyleBackColor = false;
            this.buttonStatusServico.Click += new System.EventHandler(this.buttonStatusServico_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Descrição";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Categoria:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Valor:";
            // 
            // textBoxServico
            // 
            this.textBoxServico.Location = new System.Drawing.Point(6, 85);
            this.textBoxServico.Name = "textBoxServico";
            this.textBoxServico.Size = new System.Drawing.Size(139, 22);
            this.textBoxServico.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Serviço:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de serviço";
            // 
            // cadastro_de_serviço
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "cadastro_de_serviço";
            this.Text = "cadastro_de_serviço";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoServico3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoServico2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoServico1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxServico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxFotoServico3;
        private System.Windows.Forms.PictureBox pictureBoxFotoServico2;
        private System.Windows.Forms.PictureBox pictureBoxFotoServico1;
        private System.Windows.Forms.Button buttonStatusServico;
        private System.Windows.Forms.RichTextBox richTextBoxDescricao;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxValor;
        private System.Windows.Forms.Button buttonFotoServico3;
        private System.Windows.Forms.Button buttonFotoServico2;
        private System.Windows.Forms.Button ButtonFotoServico1;
    }
}