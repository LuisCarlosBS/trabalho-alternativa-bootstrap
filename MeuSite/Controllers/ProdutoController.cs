using MeuSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeuSite.Controllers
{
   
    public class ProdutoController : Controller
    {
        ProdutoBusiness produtoBusiness = new ProdutoBusiness();
        // GET: Produto
        public ActionResult Index()
        {
            //Executa a lista de produtos no banco de dados.
            var lista = produtoBusiness.Listar();
            return View(lista);
        }

        public ActionResult Detalhes(int id)
        {
            //Executa a lista de produtos no banco de dados.
            var prod = produtoBusiness.Buscar(id);
            return View(prod);
        }

        public ActionResult Deletar(int id)
        {
            produtoBusiness.Deletar(id);
            return RedirectToAction("Index");
        }

        public ActionResult Novo()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Novo(Produto p)
        {
            produtoBusiness.Inserir(p);
            return RedirectToAction("index");
        }

        public ActionResult Alterar(int id)
        {
            var prod = produtoBusiness.Buscar(id);
            return View(prod);
        }

        [HttpPost]
        public ActionResult Alterar(Produto p)
        {
            produtoBusiness.Alterar(p);
            return RedirectToAction("index");
        }
    }
}