namespace PLataforma_de_agendamento
{
    partial class bancoClientes
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
            this.dataGridViewListarClientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonListarClientes = new System.Windows.Forms.Button();
            this.buttonExcluirClientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListarClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListarClientes
            // 
            this.dataGridViewListarClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListarClientes.Location = new System.Drawing.Point(26, 85);
            this.dataGridViewListarClientes.Name = "dataGridViewListarClientes";
            this.dataGridViewListarClientes.Size = new System.Drawing.Size(632, 353);
            this.dataGridViewListarClientes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clientes";
            // 
            // buttonListarClientes
            // 
            this.buttonListarClientes.Location = new System.Drawing.Point(682, 106);
            this.buttonListarClientes.Name = "buttonListarClientes";
            this.buttonListarClientes.Size = new System.Drawing.Size(94, 36);
            this.buttonListarClientes.TabIndex = 2;
            this.buttonListarClientes.Text = "Listar Clientes";
            this.buttonListarClientes.UseVisualStyleBackColor = true;
            this.buttonListarClientes.Click += new System.EventHandler(this.buttonListarClientes_Click);
            // 
            // buttonExcluirClientes
            // 
            this.buttonExcluirClientes.Location = new System.Drawing.Point(682, 181);
            this.buttonExcluirClientes.Name = "buttonExcluirClientes";
            this.buttonExcluirClientes.Size = new System.Drawing.Size(94, 36);
            this.buttonExcluirClientes.TabIndex = 3;
            this.buttonExcluirClientes.Text = "Excluir Cliente";
            this.buttonExcluirClientes.UseVisualStyleBackColor = true;
            this.buttonExcluirClientes.Click += new System.EventHandler(this.buttonExcluirClientes_Click);
            // 
            // bancoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExcluirClientes);
            this.Controls.Add(this.buttonListarClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewListarClientes);
            this.Name = "bancoClientes";
            this.Text = "bancoClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListarClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListarClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonListarClientes;
        private System.Windows.Forms.Button buttonExcluirClientes;
    }
}