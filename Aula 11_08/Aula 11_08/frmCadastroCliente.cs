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

namespace Aula_11_08
{
    public partial class frmCadastroCliente : Form
    {
        string connectionString = @"Server=.;Database=BDCADASTRO;Trusted_Connection=True;" ;
        bool novo;

        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            tsbNovo.Enabled = true;
            tsbSalvar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbExcluir.Enabled = false;
            btnBuscar.Enabled = true;

            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            mskCEP.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtUf.Enabled = false;
            mskTelefone.Enabled = false;

        }

        private void tsbNovo_Click(object sender, EventArgs e)
        {
            tsbNovo.Enabled = false;
            tsbSalvar.Enabled = true;
            tsbCancelar.Enabled = true;
            tsbExcluir.Enabled = false;
            btnBuscar.Enabled = false;

            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            mskCEP.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtUf.Enabled = true;
            mskTelefone.Enabled = true;

            novo = true;
        }

        private void tsbSalvar_Click(object sender, EventArgs e)
        {
            if (novo)
            {
                string sql = "insert into cliente (nome, endereco, cep, " +
                    "bairro, cidade, uf, telefone) values " +
                    "(@Nome, @Endereco, @Cep, @Bairro, @Cidade, @Uf, @Telefone)";

                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Nome",txtNome.Text);
                cmd.Parameters.AddWithValue("@Endereco", txtEndereco.Text);
                cmd.Parameters.AddWithValue("@Cep", mskCEP.Text);
                cmd.Parameters.AddWithValue("@Bairro", txtBairro.Text);
                cmd.Parameters.AddWithValue("@Cidade", txtCidade.Text);
                cmd.Parameters.AddWithValue("@Uf", txtUf.Text);
                cmd.Parameters.AddWithValue("@Telefone", mskTelefone.Text);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if(i > 0)
                    {
                        MessageBox.Show("Registro incluído com sucesso");
                        novo = false;
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show("Erro: "+ex.ToString());
                }
                finally { 
                    con.Close(); 
                }
            }
            else
            {
                //Editar
                string sql_editar = "update cliente set nome = @Nome, " +
                    "endereco = @Endereco, cep = @Cep, Bairro = @Bairro, " +
                    "cidade = @Cidade, uf = @Uf, telefone = @Telefone " +
                    "where id = @Id";

                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql_editar, con);
                cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@Endereco", txtEndereco.Text);
                cmd.Parameters.AddWithValue("@Cep", mskCEP.Text);
                cmd.Parameters.AddWithValue("@Bairro", txtBairro.Text);
                cmd.Parameters.AddWithValue("@Cidade", txtCidade.Text);
                cmd.Parameters.AddWithValue("@Uf", txtUf.Text);
                cmd.Parameters.AddWithValue("@Telefone", mskTelefone.Text);
                cmd.Parameters.AddWithValue("@Id", txtId.Text);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if(i > 0)
                    {
                        MessageBox.Show("Registro atualizado com sucesso");
                    }
                }
                catch ( Exception ex)
                {
                    MessageBox.Show("Erro");
                }
                finally { 
                    con.Close(); 
                }
            }
            //Colocar a tela no estado inicial
            tsbNovo.Enabled = true;
            tsbSalvar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbExcluir.Enabled = false;
            btnBuscar.Enabled = true;

            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            mskCEP.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtUf.Enabled = false;
            mskTelefone.Enabled = false;

            txtNome.Text = "";
            txtEndereco.Text = "";
            mskCEP.Text =  "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtUf.Text = "";
            mskTelefone.Text = "";
            txtId.Text = "";
        }
    }
}
