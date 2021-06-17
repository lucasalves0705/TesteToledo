using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TesteToledo.Models;
using Repository.Repositorio;
using Repository.Models;
using AutoMapper;

namespace TesteToledo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult Consultar(string nome) { 
            try 
	        {
                List<Cliente> clientes_entity = (new ClienteRepositorio()).Localizar(nome);

                var mapper = new Mapper(AutoMapperConfig.RegisterMappings());
                List<ClienteJsonModel> clientes = mapper.Map<List<ClienteJsonModel>>(clientes_entity);

                for(int i=0; i < clientes_entity.Count(); i++)
                {
                    Cidade cidade = (new CidadeRepositorio()).Localizar(clientes_entity[i].CodigoCidade);
                    clientes[i].Cidade = cidade.Descricao ?? "-";
                }

                return new JsonResult(clientes);
            }
	        catch (Exception ex)
	        {
                return new JsonResult(null);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
