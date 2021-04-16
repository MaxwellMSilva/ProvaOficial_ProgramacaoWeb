using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prova.Models
{
    public class Produto
    {
        public int codigoProduto { get; set; }
        public double preco { get; set; }
        public string descricao { get; set; }
        public string categoria { get; set; }
        public string observacao { get; set; }
    }
}
