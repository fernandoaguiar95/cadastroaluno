using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroAlunos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveAluno_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaodb = new MySqlConnectionStringBuilder();
            conexaodb.Server = "localhost";
            conexaodb.Database = "faculdade";
            conexaodb.UserID = "root";
            conexaodb.Password = "";

            MySqlConnection connectionString = new MySqlConnection(conexaodb.ToString());

            try
            {
                connectionString.Open();
                MessageBox.Show("Conexão aberta");

                MySqlCommand cmd = connectionString.CreateCommand();
                cmd.CommandText = "INSERT INTO alunos(nome, email, data_nascimento) VALUES ('" + tbNome.Text + "', '"
                                    + tbEmail.Text + "', '" + tbData.Text + "')";
                cmd.ExecuteNonQuery();

                connectionString.Close();
                MessageBox.Show("Aluno adicionado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível conectar!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
