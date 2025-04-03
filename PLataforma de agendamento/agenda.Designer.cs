namespace PLataforma_de_agendamento
{
    partial class agenda
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
            this.dataGridViewAgenda = new System.Windows.Forms.DataGridView();
            this.buttonListarAgenda = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAgenda
            // 
            this.dataGridViewAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAgenda.Location = new System.Drawing.Point(26, 29);
            this.dataGridViewAgenda.Name = "dataGridViewAgenda";
            this.dataGridViewAgenda.Size = new System.Drawing.Size(762, 381);
            this.dataGridViewAgenda.TabIndex = 0;
            // 
            // buttonListarAgenda
            // 
            this.buttonListarAgenda.Location = new System.Drawing.Point(152, 416);
            this.buttonListarAgenda.Name = "buttonListarAgenda";
            this.buttonListarAgenda.Size = new System.Drawing.Size(106, 23);
            this.buttonListarAgenda.TabIndex = 1;
            this.buttonListarAgenda.Text = "Listar agenda";
            this.buttonListarAgenda.UseVisualStyleBackColor = true;
            this.buttonListarAgenda.Click += new System.EventHandler(this.buttonListarAgenda_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(315, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Deletar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonListarAgenda);
            this.Controls.Add(this.dataGridViewAgenda);
            this.Name = "agenda";
            this.Text = "agenda";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAgenda;
        private System.Windows.Forms.Button buttonListarAgenda;
        private System.Windows.Forms.Button button2;
    }
}