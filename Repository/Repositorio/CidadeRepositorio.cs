using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Repository.Models;

namespace Repository.Repositorio
{
    public class CidadeRepositorio
    {
        public Cidade Localizar(int? id)
        {
            Cidade cidade = null;
            using (empresaContext db = new empresaContext())
            {
                cidade = (from c in db.Cidades where c.Codigo == id select c).FirstOrDefault();
            }
            return cidade;
        }

        public List<Cidade> Todas()
        {
            List<Cidade> cidades = null;
            using (empresaContext db = new empresaContext())
            {
                cidades = (from c in db.Cidades select c).ToList();
            }
            return cidades;
        }
    }
}
