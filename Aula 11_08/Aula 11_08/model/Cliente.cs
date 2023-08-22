using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_11_08.model
{
    internal class Cliente
    {
        //Construtor Padrão
        public Cliente() { 
 
        
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Cep {get; set; }
        public string Bairro { get; set;}
        public string Cidade { get; set; }
        public string Uf { get; set;}
        public string Telefone { get; set;} 

    }
}
