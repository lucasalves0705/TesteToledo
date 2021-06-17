using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositorio;
using TesteToledo.Models;
using AutoMapper;

namespace TesteToledo.Controllers
{
    public class ClienteController : Controller
    {
        // GET: ClienteController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ClienteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClienteController/Create
        public ActionResult Cadastrar()
        {
            List<Cidade> cidade_entity = (new CidadeRepositorio()).Todas();

            var mapper = new Mapper(AutoMapperConfig.RegisterMappings());
            List<CidadeModel> cidades = mapper.Map<List<CidadeModel>>(cidade_entity);
            ViewBag.cidades = cidades;

            return View();
        }

        // POST: ClienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Salvar(IFormCollection dados)
        {
            try
            {
                if(dados["nome"] != "" &&
                    dados["cpf"] != "" &&
                    dados["rua"] != "" &&
                    dados["numero"] != "" &&
                    dados["bairro"] != "" &&
                    dados["cidade"] != "" &&
                    dados["telefone"] != "" &&
                    dados["celular"] != ""
                )
                {
                    ClienteModel cliente = new ClienteModel()
                    {
                        Nome = dados["nome"],
                        Cpf = dados["cpf"],
                        Rua = dados["rua"],
                        Numero = dados["numero"],
                        Bairro = dados["bairro"],
                        CodigoCidade = int.Parse(dados["cidade"].ToString()),
                        Telefone = dados["telefone"],
                        Celular = dados["celular"]
                    };

                    var mapper = new Mapper(AutoMapperConfig.RegisterMappings());
                    Cliente cliente_entity = mapper.Map<Cliente>(cliente);

                    (new ClienteRepositorio()).Inserir(cliente_entity);

                }

                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClienteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
