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
            txtNome.Focus();

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
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show("Erro: "+ex.ToString());
                }
                finally { 
                    con.Close();
                    novo = false;
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

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            tsbNovo.Enabled=true;//ativa o botão novo
            tsbSalvar.Enabled=false;
            tsbCancelar.Enabled=false;
            tsbExcluir.Enabled=false;
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
            mskCEP.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtUf.Text = "";
            mskTelefone.Text = "";
        }

        private void tsbExcluir_Click(object sender, EventArgs e)
        {
            string sqlApagar = "delete from cliente where Id = @Id";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sqlApagar, con);

            //Passando parâmetros para a sentença SQL
            cmd.Parameters.AddWithValue("@Id",txtId.Text);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Cliente deletado com Sucesso!!!\n" +
                        "Cliente: " + txtNome.Text);
                }
            }
            catch(Exception ex) {
                MessageBox.Show("Erro ao Apagar!\nErro:" + ex.ToString());
            }
            finally { 
                con.Close(); 
            }

            tsbNovo.Enabled = true;//ativa o botão novo
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
            mskCEP.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtUf.Text = "";
            mskTelefone.Text = "";

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string sqlBuscarId = "select * from cliente where Id = @Id";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sqlBuscarId, con);

            //Passando parâmetros para a sentença SQL
            cmd.Parameters.AddWithValue("@Id", txtBuscar.Text);
            cmd.CommandType = CommandType.Text;
             
            SqlDataReader tabCliente;
            con.Open();
            try
            {
                tabCliente = cmd.ExecuteReader();
                if (tabCliente.Read())
                {
                    txtId.Text = tabCliente[0].ToString();
                    txtNome.Text = tabCliente[1].ToString();
                    txtEndereco.Text = tabCliente[2].ToString();
                    mskCEP.Text = tabCliente[3].ToString();
                    txtBairro.Text = tabCliente[4].ToString();
                    txtCidade.Text = tabCliente[5].ToString();
                    txtUf.Text= tabCliente[6].ToString();
                    mskTelefone.Text= tabCliente[7].ToString();

                    //ativar controle dos botões
                    tsbNovo.Enabled = false;
                    tsbSalvar.Enabled = true;
                    tsbCancelar.Enabled = true;
                    tsbExcluir.Enabled = true;
                    
                    txtNome.Enabled = true;
                    txtEndereco.Enabled = true;
                    mskCEP.Enabled = true;
                    txtBairro.Enabled = true;
                    txtCidade.Enabled = true;
                    txtUf.Enabled = true;
                    mskTelefone.Enabled = true;
                    txtNome.Focus();
                    novo = false;
                }
                else
                {
                    MessageBox.Show("Cliente não Encontrado!");
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Erro ao Buscar!!!");
            }

            finally { 
                con.Close(); 
            }
            txtBuscar.Text = string.Empty;

        }
    }
}
