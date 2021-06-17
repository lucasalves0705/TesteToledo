using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteToledo.Models
{
    public class ClienteJsonModel
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }

        public ClienteJsonModel(int codigo, string nome, string cpf, string rua, string numero, string cidade, string bairro, string telefone, string celular)
        {
            Codigo = codigo;
            Nome = nome;
            Cpf = cpf;
            Rua = rua;
            Numero = numero;
            Cidade = cidade;
            Bairro = bairro;
            Telefone = telefone;
            Celular = celular;
        }

        public ClienteJsonModel(string nome, string cpf, string rua, string numero, string cidade, string bairro, string telefone, string celular)
        {
            Nome = nome;
            Cpf = cpf;
            Rua = rua;
            Numero = numero;
            Cidade = cidade;
            Bairro = bairro;
            Telefone = telefone;
            Celular = celular;
        }

        public ClienteJsonModel()
        {
        }
    }
}
