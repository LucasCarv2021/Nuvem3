namespace Lista_de_Clientes
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnNovoRegistro = new System.Windows.Forms.Button();
            this.createBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCliente = new System.Windows.Forms.DataGridViewLinkColumn();
            this.txtNOMEHOME = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.createBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Bronze",
            "Prata",
            "Ouro"});
            this.cbCategoria.Location = new System.Drawing.Point(346, 33);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 23);
            this.cbCategoria.TabIndex = 1;
            this.cbCategoria.Text = "Categoria";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(473, 33);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(98, 23);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnNovoRegistro
            // 
            this.btnNovoRegistro.Location = new System.Drawing.Point(663, 33);
            this.btnNovoRegistro.Name = "btnNovoRegistro";
            this.btnNovoRegistro.Size = new System.Drawing.Size(124, 24);
            this.btnNovoRegistro.TabIndex = 3;
            this.btnNovoRegistro.Text = "Novo Registro";
            this.btnNovoRegistro.UseVisualStyleBackColor = true;
            this.btnNovoRegistro.Click += new System.EventHandler(this.btnNovoRegistro_Click);
            // 
            // createBindingSource
            // 
            this.createBindingSource.DataSource = typeof(Lista_de_Clientes.Create);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.txtCategoria,
            this.idCliente});
            this.dataGridView.Location = new System.Drawing.Point(12, 63);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(775, 180);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 500;
            // 
            // txtCategoria
            // 
            this.txtCategoria.DataPropertyName = "Categoria";
            this.txtCategoria.HeaderText = "Categoria";
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.Width = 120;
            // 
            // idCliente
            // 
            this.idCliente.DataPropertyName = "idCliente";
            this.idCliente.HeaderText = "Editar";
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Text = "Editar";
            this.idCliente.UseColumnTextForLinkValue = true;
            this.idCliente.Width = 120;
            // 
            // txtNOMEHOME
            // 
            this.txtNOMEHOME.Location = new System.Drawing.Point(12, 33);
            this.txtNOMEHOME.Name = "txtNOMEHOME";
            this.txtNOMEHOME.Size = new System.Drawing.Size(328, 23);
            this.txtNOMEHOME.TabIndex = 5;
            this.txtNOMEHOME.Text = "Nome";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 255);
            this.Controls.Add(this.txtNOMEHOME);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnNovoRegistro);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.cbCategoria);
            this.Name = "Home";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.createBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox cbCategoria;
        private Button btnPesquisar;
        private Button btnNovoRegistro;
        private BindingSource createBindingSource;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn txtCategoria;
        private DataGridViewLinkColumn idCliente;
        private TextBox txtNOMEHOME;
    }
}