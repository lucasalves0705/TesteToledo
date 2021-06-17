using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Cidade
    {
        public Cidade()
        {
            Clientes = new HashSet<Cliente>();
        }

        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public string Uf { get; set; }

        public virtual Estado UfNavigation { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
