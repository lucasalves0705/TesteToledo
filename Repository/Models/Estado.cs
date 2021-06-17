using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Estado
    {
        public Estado()
        {
            Cidades = new HashSet<Cidade>();
        }

        public string Uf { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Cidade> Cidades { get; set; }
    }
}
