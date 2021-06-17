using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Repository.Models;

namespace Repository.Repositorio
{
    public class ClienteRepositorio
    {
        public void Inserir(Cliente cliente)
        {
            using (empresaContext db = new empresaContext())
            {
                db.Add(cliente);
                db.SaveChanges();
            }
        }

        public List<Cliente> Localizar(string pesquisa)
        {
            List<Cliente> clientes = null;
            using (empresaContext db = new empresaContext())
            {
                clientes = db.Clientes.Where(c => c.Nome.Contains(pesquisa)).ToList();
            }

            return clientes;
        }
    }
}
