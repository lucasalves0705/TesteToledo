using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Categoria
    {
        public Categoria()
        {
            Produtos = new HashSet<Produto>();
        }

        public int Codigo { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
