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
        public void apagarDados(int valor)
        {
            throw new NotImplementedException();
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
