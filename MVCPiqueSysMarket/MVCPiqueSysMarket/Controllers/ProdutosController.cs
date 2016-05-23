using MVCPiqueSysMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVCPiqueSysMarket.Controllers
{
    public class ProdutosController : Controller
    {

        public static List<Produtos> listaDeProdutos = new List<Produtos>
        {
            new Produtos {Id = 1, Nome = "Banana", Preco = 3, Descricao = "Bananas", Categoria = "Fruta"  }
        };
        // GET: Produtos
        public ActionResult Index()
        {
            return View(listaDeProdutos);
        }
        public ActionResult index_Master()
        {
            return View(listaDeProdutos);
        }
        // GET: Produtos/Details/5
        public ActionResult Detalhes(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produtos produto = listaDeProdutos.Find(x => x.Id == id);//instancia um produto do tipo produto e procura o id na lista
            if (produto == null)//se o produto for nulo retorna pagina que não existe
            {
                return HttpNotFound();
            }
            return View(produto);
        }

        // GET: Produtos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produtos/Create
        [HttpPost]
        public ActionResult Create(Produtos produto)
        {
            try
            {
                listaDeProdutos.Add(produto);//add um produto na lista
                return RedirectToAction("Index");// redireciona para a index
            }
            catch
            {
                //Redireciona para a página de erro
                return View();
            }
        }

        // GET: Produtos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produtos produto = listaDeProdutos.Find(x => x.Id == id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }

        // POST: Produtos/Edit/5
        [HttpPost]
        public ActionResult Edit(Produtos produtos)
        {
            try
            {
                Produtos produto = listaDeProdutos.Find(x => x.Id == produtos.Id);
                produto.Id = produtos.Id;
                produto.Nome = produtos.Nome;
                produto.Preco = produtos.Preco;
                produto.Descricao = produtos.Descricao;
                produto.Categoria = produtos.Categoria;

                return RedirectToAction("Index");
            }
            catch
            {
                //Redireciona para a página de erro
                return View();
            }
        }

        // GET: Produtos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produtos produto = listaDeProdutos.Find(x => x.Id == id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }

        // POST: Produtos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                Produtos produto = listaDeProdutos.Find(x => x.Id == id);
                listaDeProdutos.Remove(produto);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }

        }
    }
}
