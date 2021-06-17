using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Cliente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public int? CodigoCidade { get; set; }
        public string Bairro { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }

        public virtual Cidade CodigoCidadeNavigation { get; set; }
    }
}
