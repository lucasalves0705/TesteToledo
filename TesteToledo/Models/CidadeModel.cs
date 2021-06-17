using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteToledo.Models
{
    public class CidadeModel
    {

        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public string Uf { get; set; }

        public CidadeModel(int codigo, string descricao, string uf)
        {
            Codigo = codigo;
            Descricao = descricao;
            Uf = uf;
        }

        public CidadeModel()
        {
        }
    }
}
