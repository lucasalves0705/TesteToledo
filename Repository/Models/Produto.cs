using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Produto
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public int? CodigoCategoria { get; set; }
        public int? Qtde { get; set; }
        public string Imagem { get; set; }
        public string DescricaoLonga { get; set; }
        public decimal? Valor { get; set; }

        public virtual Categoria CodigoCategoriaNavigation { get; set; }
    }
}
