namespace ControleBanco
{
    partial class Banco
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_numConta = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.label_numConta = new System.Windows.Forms.Label();
            this.label_senha = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_cadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_numConta
            // 
            this.txt_numConta.Location = new System.Drawing.Point(109, 23);
            this.txt_numConta.Name = "txt_numConta";
            this.txt_numConta.Size = new System.Drawing.Size(180, 20);
            this.txt_numConta.TabIndex = 1;
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(109, 49);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(180, 20);
            this.txt_senha.TabIndex = 2;
            // 
            // label_numConta
            // 
            this.label_numConta.AutoSize = true;
            this.label_numConta.Location = new System.Drawing.Point(12, 26);
            this.label_numConta.Name = "label_numConta";
            this.label_numConta.Size = new System.Drawing.Size(93, 13);
            this.label_numConta.TabIndex = 3;
            this.label_numConta.Text = "Numero da Conta:";
            // 
            // label_senha
            // 
            this.label_senha.AutoSize = true;
            this.label_senha.Location = new System.Drawing.Point(12, 52);
            this.label_senha.Name = "label_senha";
            this.label_senha.Size = new System.Drawing.Size(41, 13);
            this.label_senha.TabIndex = 4;
            this.label_senha.Text = "Senha:";
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Verdana", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(12, 98);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(311, 55);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "ACESSAR";
            this.btn_login.UseVisualStyleBackColor = true;
            // 
            // btn_cadastro
            // 
            this.btn_cadastro.Font = new System.Drawing.Font("Verdana", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastro.Location = new System.Drawing.Point(12, 159);
            this.btn_cadastro.Name = "btn_cadastro";
            this.btn_cadastro.Size = new System.Drawing.Size(311, 27);
            this.btn_cadastro.TabIndex = 6;
            this.btn_cadastro.Text = "NOVA CONTA";
            this.btn_cadastro.UseVisualStyleBackColor = true;
            // 
            // Banco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 207);
            this.Controls.Add(this.btn_cadastro);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label_senha);
            this.Controls.Add(this.label_numConta);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_numConta);
            this.Name = "Banco";
            this.Text = "Banco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_numConta;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label label_numConta;
        private System.Windows.Forms.Label label_senha;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_cadastro;
    }
}

