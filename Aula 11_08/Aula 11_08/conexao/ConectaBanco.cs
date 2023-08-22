using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_11_08.conexao
{
    internal class ConectaBanco
    {
        SqlConnection con;
        string connectionString = @"Server=.;Database=BDCADASTRO;
                                    Trusted_Connection=True;";

        public SqlConnection conectaSqlServer()
        {
            //cria a conexão com o banco de dados
            con = new SqlConnection(connectionString);

            return con;
        }
    }
}
