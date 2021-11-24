namespace Lista_de_Clientes
{
    partial class Create
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.cbCategoriaCreate = new System.Windows.Forms.ComboBox();
            this.cbAtivo = new System.Windows.Forms.CheckBox();
            this.btnNovoRegistro = new System.Windows.Forms.Button();
            this.bntGravar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(25, 48);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(310, 23);
            this.txtNome.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(385, 48);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(310, 23);
            this.txtEmail.TabIndex = 1;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(25, 121);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(310, 23);
            this.txtTelefone.TabIndex = 2;
            // 
            // cbCategoriaCreate
            // 
            this.cbCategoriaCreate.FormattingEnabled = true;
            this.cbCategoriaCreate.Items.AddRange(new object[] {
            "Bronze",
            "Prata",
            "Ouro"});
            this.cbCategoriaCreate.Location = new System.Drawing.Point(385, 121);
            this.cbCategoriaCreate.Name = "cbCategoriaCreate";
            this.cbCategoriaCreate.Size = new System.Drawing.Size(121, 23);
            this.cbCategoriaCreate.TabIndex = 3;
            this.cbCategoriaCreate.Text = "Categoria";
            // 
            // cbAtivo
            // 
            this.cbAtivo.AutoSize = true;
            this.cbAtivo.Location = new System.Drawing.Point(555, 125);
            this.cbAtivo.Name = "cbAtivo";
            this.cbAtivo.Size = new System.Drawing.Size(15, 14);
            this.cbAtivo.TabIndex = 4;
            this.cbAtivo.UseVisualStyleBackColor = true;
            // 
            // btnNovoRegistro
            // 
            this.btnNovoRegistro.Location = new System.Drawing.Point(25, 193);
            this.btnNovoRegistro.Name = "btnNovoRegistro";
            this.btnNovoRegistro.Size = new System.Drawing.Size(114, 23);
            this.btnNovoRegistro.TabIndex = 5;
            this.btnNovoRegistro.Text = "Novo Registro";
            this.btnNovoRegistro.UseVisualStyleBackColor = true;
            this.btnNovoRegistro.Click += new System.EventHandler(this.btnNovoRegistro_Click);
            // 
            // bntGravar
            // 
            this.bntGravar.Location = new System.Drawing.Point(161, 193);
            this.bntGravar.Name = "bntGravar";
            this.bntGravar.Size = new System.Drawing.Size(75, 23);
            this.bntGravar.TabIndex = 6;
            this.bntGravar.Text = "Gravar";
            this.bntGravar.UseVisualStyleBackColor = true;
            this.bntGravar.Click += new System.EventHandler(this.bntGravar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(260, 193);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(620, 193);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(545, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ativo";
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 233);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.bntGravar);
            this.Controls.Add(this.btnNovoRegistro);
            this.Controls.Add(this.cbAtivo);
            this.Controls.Add(this.cbCategoriaCreate);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Name = "Create";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private ComboBox cbCategoriaCreate;
        private CheckBox cbAtivo;
        private Button btnNovoRegistro;
        private Button bntGravar;
        private Button btnVoltar;
        private Button btnExcluir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}