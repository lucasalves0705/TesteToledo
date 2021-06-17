using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Cliente1
    {
        public int CliCodigo { get; set; }
        public string CliNome { get; set; }
        public DateTime? CliDatanascimento { get; set; }
        public string CliCpf { get; set; }
        public string CliRg { get; set; }
    }
}
