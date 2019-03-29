using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Vendas.Models
{
    public class Fornecedor
    {
        public Fornecedor(){
            Produtos = new HashSet<Produto>();
        }
        public int Id {get; set;}
        public string Nome {get; set;}
        public string Contato_Telefone { get; set; }
        public string Contato_Email {get; set;}
        public string Endereco { get; set; }
        public ICollection<Produto> Produtos {get; set;}
    }
}