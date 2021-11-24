using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_de_Clientes
{

    public partial class Create : Form
    {


        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;

        public string ParametroNome
        {
            get { return txtNome.Text; }
            set { txtNome.Text = value; }
        }

        public Create(bool btnExcluirCondition)
        {
            InitializeComponent();
            btnExcluir.Enabled = btnExcluirCondition;
        }

        private void btnNovoRegistro_Click(object sender, EventArgs e)
        {

            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=lista_cliente;Uid=root;Pwd=09202630;");

                string strSQL = "INSERT INTO cliente (Nome,Email,Telefone,Categoria,Ativo) VALUES (@NOME,@EMAIL,@TELEFONE,@CATEGORIA,@ATIVO);";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                comando.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                comando.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text);
                comando.Parameters.AddWithValue("@CATEGORIA", cbCategoriaCreate.Text);
                comando.Parameters.AddWithValue("@ATIVO", cbAtivo.Checked);

                conexao.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }


        }

        private void bntGravar_Click(object sender, EventArgs e)
        {

            string strSQL = "INSERT INTO cliente (Nome,Email,Telefone,Categoria,Ativo) VALUES (@NOME,@EMAIL,@TELEFONE,@CATEGORIA,@ATIVO);";

            comando = new MySqlCommand(strSQL, conexao);
            comando.Parameters.AddWithValue("@NOME", txtNome.Text);
            comando.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
            comando.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text);
            comando.Parameters.AddWithValue("@CATEGORIA", cbCategoriaCreate.Text);
            comando.Parameters.AddWithValue("@ATIVO", cbAtivo.Checked);

            conexao.Open();

            comando.ExecuteNonQuery();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            string strSQL = " ";

            comando = new MySqlCommand(strSQL, conexao);

            conexao.Open();

            comando.ExecuteNonQuery();

        }

    }
}
