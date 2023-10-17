using Aula_11_08.conexao;
using Aula_11_08.controller;
using Aula_11_08.model;
using Aula_11_08.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.LinkLabel;

namespace Aula_11_08
{
    public partial class frmCadastroCliente : Form
    {
   
        string connectionString = @"Server=.;Database=BDCADASTRO;
                                    Trusted_Connection=True;";
        bool novo;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable clientes;
        SqlDataReader tabCliente;
        DataRow[] linhaAtual;

        int posicao = 0;
        //Carrega as informações no DatagridView1 com os dados dos clientes
        public void carregarTabela()
        {
            //define a instrução SQL
            string strSql = "SELECT * FROM cliente order by nome";
            
            ConectaBanco conectaBanco = new ConectaBanco();
            con = conectaBanco.conectaSqlServer();

         

            //cria o objeto command para executar a instruçao sql
            cmd = new SqlCommand(strSql, con);
            //abre a conexao
            con.Open();
            //define o tipo do comando
            cmd.CommandType = CommandType.Text;
            //cria um dataadapter
            da = new SqlDataAdapter(cmd);
            //cria um objeto datatable
            clientes = new DataTable();
            //preenche o datatable via dataadapter
            da.Fill(clientes);
            //atribui o datatable ao datagridview para exibir o resultado
            dataGridView1.DataSource = clientes;

            linhaAtual = clientes.Select();

            posicao = Int32.Parse(TotalRegistros()) - 1;
            if(posicao == -1)
            {
                MessageBox.Show("Não Existem Registros!");
            }
            else
            {
                txtId.Text = linhaAtual[0]["Id"].ToString();
                txtNome.Text = linhaAtual[0]["nome"].ToString();
                txtEndereco.Text = linhaAtual[0]["endereco"].ToString();
                mskCEP.Text = linhaAtual[0]["cep"].ToString();
                txtBairro.Text = linhaAtual[0]["bairro"].ToString();
                txtCidade.Text = linhaAtual[0]["cidade"].ToString();
                txtUf.Text = linhaAtual[0]["uf"].ToString();
                mskTelefone.Text = linhaAtual[0]["telefone"].ToString();
            }
           
        }

        //Construtor da Classe frmCadastroCliente
        public frmCadastroCliente()
        {
            InitializeComponent();
            carregarTabela();
            
        }
       
        string TotalRegistros()
        {
            //CONSULTA QUE RETORNA A QUANTIDADE DE CLIENTES NO BANCO
            string sqlBuscarId = "select count(nome) as total from cliente";
            con = new SqlConnection(connectionString);
            cmd = new SqlCommand(sqlBuscarId, con);

            //Passando parâmetros para a sentença SQL
            cmd.Parameters.AddWithValue("@nome", txtBuscar.Text + "%");
            cmd.CommandType = CommandType.Text;

            con.Open();
            string total = "";
            try
            {
                tabCliente = cmd.ExecuteReader();
                if (tabCliente.Read())
                {
                    total = (tabCliente[0].ToString());
                    
                }
                else
                {
                    MessageBox.Show("Cliente não Encontrado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Buscar!!!");
            }

            finally
            {
                con.Close();
            }
            
            return total;
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
            txtCidade.Enabled = false;
            
            lblTotal.Text = TotalRegistros();

        }

        private void tsbNovo_Click(object sender, EventArgs e)
        {

            limpaCampos();

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

        private void limpaCampos()
        {
            txtNome.Text = "";
            txtEndereco.Text = "";
            mskCEP.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtUf.Text = "";
            mskTelefone.Text = "";
            txtId.Text = "";
        }

        private void tsbSalvar_Click(object sender, EventArgs e)
        {
            if (novo)
            {
                Cliente cliente = new Cliente();
                cliente.Nome = txtNome.Text;
                cliente.Endereco = txtEndereco.Text;
                cliente.Bairro = txtBairro.Text;
                cliente.Cidade = txtCidade.Text;
                cliente.Uf = txtUf.Text;
                cliente.Telefone = mskTelefone.Text;
                cliente.Cep = mskCEP.Text;

                C_Cliente c_Cliente = new C_Cliente();
                c_Cliente.inserirDados(cliente);
               
            }
            else
            {

                Cliente cliente = new Cliente();
                cliente.Id = Int32.Parse(txtId.Text);
                cliente.Nome = txtNome.Text;
                cliente.Endereco = txtEndereco.Text;
                cliente.Bairro = txtBairro.Text;
                cliente.Cidade = txtCidade.Text;
                cliente.Uf = txtUf.Text;
                cliente.Telefone = mskTelefone.Text;
                cliente.Cep = mskCEP.Text;

                C_Cliente c_Cliente = new C_Cliente();
                c_Cliente.editarDados(cliente);

            }

            carregarTabela();

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

            lblTotal.Text = TotalRegistros();

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
            C_Cliente cc = new C_Cliente();
            cc.apagarDados(Int32.Parse(txtId.Text));

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

            carregarTabela();
            lblTotal.Text = TotalRegistros();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            //C_Cliente c = new C_Cliente();
            //Cliente x = new Cliente();
            //x = (Cliente)c.buscarId(11);

            //MessageBox.Show("Nome: " + x.Nome);

            string sqlBuscarId = "select * from cliente where nome LIKE @nome order by nome";
            con = new SqlConnection(connectionString);
            cmd = new SqlCommand(sqlBuscarId, con);

            //Passando parâmetros para a sentença SQL
            cmd.Parameters.AddWithValue("@nome", txtBuscar.Text+"%");
            cmd.CommandType = CommandType.Text;
             
            SqlDataReader tabCliente;
            con.Open();

//*******carregando datagrid ***************************************8
            //cria um dataadapter
            da = new SqlDataAdapter(cmd);
            //cria um objeto datatable
            clientes = new DataTable();
            //preenche o datatable via dataadapter
            da.Fill(clientes);
            //atribui o datatable ao datagridview para exibir o resultado
            dataGridView1.DataSource = clientes;
//*******************fim do carregamento do datagrid
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;// get the Row Index
            DataGridViewRow selectedRow = dataGridView1.Rows[index];

           
            txtId.Text = selectedRow.Cells[0].Value.ToString();
            //txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtEndereco.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            mskCEP.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtBairro.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtCidade.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtUf.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            mskTelefone.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            posicao = Int32.Parse(TotalRegistros())-1;

            if(posicao > 0)
            {
                posicao = 0;
                txtId.Text = linhaAtual[posicao]["id"].ToString();
                txtNome.Text = linhaAtual[posicao]["nome"].ToString();
                txtEndereco.Text = linhaAtual[posicao]["endereco"].ToString();
                mskCEP.Text = linhaAtual[posicao]["cep"].ToString();
                txtBairro.Text = linhaAtual[posicao]["bairro"].ToString();
                txtCidade.Text = linhaAtual[posicao]["cidade"].ToString();
                txtUf.Text = linhaAtual[posicao]["uf"].ToString();
                mskTelefone.Text = linhaAtual[posicao]["telefone"].ToString();

                //seleciona no datagridview a primeira linha
                dataGridView1.Rows[posicao].Selected = true;

            }
            else
            {
                MessageBox.Show("Não Existem Registros!");
            }
            
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            posicao = (Int32.Parse(TotalRegistros())) -1;
            if(posicao == -1)
            {
                MessageBox.Show("Não Existem Registros");
            }
            else
            {
                txtId.Text = linhaAtual[posicao]["id"].ToString();
                txtNome.Text = linhaAtual[posicao]["nome"].ToString();
                txtEndereco.Text = linhaAtual[posicao]["endereco"].ToString();
                mskCEP.Text = linhaAtual[posicao]["cep"].ToString();
                txtBairro.Text = linhaAtual[posicao]["bairro"].ToString();
                txtCidade.Text = linhaAtual[posicao]["cidade"].ToString();
                txtUf.Text = linhaAtual[posicao]["uf"].ToString();
                mskTelefone.Text = linhaAtual[posicao]["telefone"].ToString();

                dataGridView1.Rows[posicao].Selected = true;
            }
            
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if(posicao > 0) {
                posicao--;
                txtId.Text = linhaAtual[posicao]["id"].ToString();
                txtNome.Text = linhaAtual[posicao]["nome"].ToString();
                txtEndereco.Text = linhaAtual[posicao]["endereco"].ToString();
                mskCEP.Text = linhaAtual[posicao]["cep"].ToString();
                txtBairro.Text = linhaAtual[posicao]["bairro"].ToString();
                txtCidade.Text = linhaAtual[posicao]["cidade"].ToString();
                txtUf.Text = linhaAtual[posicao]["uf"].ToString();
                mskTelefone.Text = linhaAtual[posicao]["telefone"].ToString();

                dataGridView1.Rows[posicao].Selected = true;
            }
           
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if(posicao < Int32.Parse(TotalRegistros())-1)
            {
              
                    posicao++;
                    txtId.Text = linhaAtual[posicao]["id"].ToString();
                    txtNome.Text = linhaAtual[posicao]["nome"].ToString();
                    txtEndereco.Text = linhaAtual[posicao]["endereco"].ToString();
                    mskCEP.Text = linhaAtual[posicao]["cep"].ToString();
                    txtBairro.Text = linhaAtual[posicao]["bairro"].ToString();
                    txtCidade.Text = linhaAtual[posicao]["cidade"].ToString();
                    txtUf.Text = linhaAtual[posicao]["uf"].ToString();
                    mskTelefone.Text = linhaAtual[posicao]["telefone"].ToString();

                //posicionar no grid
                dataGridView1.Rows[posicao].Selected = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            //clientes é datatable
            FrmRelCliente frmRelCliente = new FrmRelCliente(clientes);
            frmRelCliente.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //FrmRelProfessor frmrelprof = new FrmRelProfessor();
            //frmrelprof.ShowDialog();
        }
    }
}
