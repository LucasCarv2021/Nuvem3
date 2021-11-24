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
    public partial class Home : Form

    {

        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;

        public Home()
        {
            InitializeComponent();

            this.Load += Home_Load;

        }



        private void btnNovoRegistro_Click(object sender, EventArgs e)
        {

            Create createForm = new Create(false);
            createForm.Show();

        }

        private void Home_Load(object sender, EventArgs e)
        {

            conexao = new MySqlConnection("Server=localhost;Database=lista_cliente;Uid=root;Pwd=09202630;Allow User Variables=True;");

            string strSQL = "Select idCliente,Nome,Categoria FROM cliente;";

            da = new MySqlDataAdapter(strSQL, conexao);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView.DataSource = dt;


        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {   

            string SQL = "Select idCliente,Nome,Categoria FROM cliente WHERE cliente.nome = '"+txtNOMEHOME.Text+"'";

            da = new MySqlDataAdapter(SQL, conexao);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView.DataSource = dt;

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Create createForm = new Create(true);
            createForm.Show();

            string SQL = "Select * FROM cliente WHERE cliente.idCliente = '" + idCliente.Text + "'";

            conexao.Open();

            dr = comando.ExecuteReader();

            while (dr.Read())
            {

                createForm.ParametroNome = Convert.ToString(dr["Nome"]);

            }

        }
    }
}
