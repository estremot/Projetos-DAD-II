using Aula_11_08.conexao;
using Aula_11_08.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_11_08.controller
{
    internal class C_Cliente : I_CRUD
    {
        SqlConnection con;
        SqlCommand cmd;

        string sqlInsere = "insert into cliente (nome, endereco, cep,bairro, cidade, uf, telefone) values (@Nome, @Endereco, @Cep, @Bairro, @Cidade, @Uf, @Telefone)";
        string sqlEditar = "update cliente set nome = @Nome, " +
                    "endereco = @Endereco, cep = @Cep, Bairro = @Bairro, " +
                    "cidade = @Cidade, uf = @Uf, telefone = @Telefone " +
                    "where id = @Id";
        string sqlApagar = "delete from cliente where Id = @Id";

        string sqlBuscarId = "select * from cliente where Id = @Id";
        public void apagarDados(int valor)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlApagar, con);

            //Passando parâmetros para a sentença SQL
            cmd.Parameters.AddWithValue("@Id", valor);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Cliente deletado com Sucesso!!!\n" +
                        "Código: " + valor);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Apagar!\nErro:" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        public Object buscarId(int valor)
        {
            //retornar um model Cliente
            Cliente cliente = new Cliente();

            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            
            cmd = new SqlCommand(sqlBuscarId, con);

            //Passando parâmetros para a sentença SQL
            cmd.Parameters.AddWithValue("@Id", valor);
            cmd.CommandType = CommandType.Text;

            SqlDataReader tabCliente;
            con.Open();


            try
            {
                tabCliente = cmd.ExecuteReader();
                if (tabCliente.Read())
                {
                    cliente.Id = Int32.Parse(tabCliente[0].ToString());
                    cliente.Nome = tabCliente[1].ToString();
                    cliente.Endereco = tabCliente[2].ToString();
                    cliente.Cep = tabCliente[3].ToString();
                    cliente.Bairro = tabCliente[4].ToString();
                    cliente.Cidade = tabCliente[5].ToString();
                    cliente.Uf = tabCliente[6].ToString();
                    cliente.Telefone = tabCliente[7].ToString();
                }
            }
            catch (Exception ex)
            {

            }
            finally { con.Close(); }
            
            return cliente;
        }

        public void consultarTodos()
        {
            throw new NotImplementedException();
        }

        public void editarDados(object obj)
        {
            Cliente cliente = new Cliente();
            cliente = (Cliente) obj;

            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlEditar, con);

            cmd.Parameters.AddWithValue("@Id", cliente.Id);
            cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@Endereco", cliente.Endereco);
            cmd.Parameters.AddWithValue("@Cep", cliente.Cep);
            cmd.Parameters.AddWithValue("@Bairro", cliente.Bairro);
            cmd.Parameters.AddWithValue("@Cidade", cliente.Cidade);
            cmd.Parameters.AddWithValue("@Uf", cliente.Uf);
            cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Registro atualizado com sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro");
            }
            finally
            {
                con.Close();
            }
        }

        public void inserirDados(object obj)
        {
            Cliente cliente = new Cliente();
            cliente = (Cliente)obj;

           ConectaBanco cb = new ConectaBanco();
           con = cb.conectaSqlServer();
           cmd = new SqlCommand(sqlInsere, con);

            cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@Endereco", cliente.Endereco);
            cmd.Parameters.AddWithValue("@Cep", cliente.Cep);
            cmd.Parameters.AddWithValue("@Bairro", cliente.Bairro);
            cmd.Parameters.AddWithValue("@Cidade", cliente.Cidade);
            cmd.Parameters.AddWithValue("@Uf", cliente.Uf);
            cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
            cmd.CommandType = CommandType.Text;
            con.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Registro incluído com sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
}
