using MVCPiqueSysMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVCPiqueSysMarket.Controllers
{
    public class UsuariosController : Controller
    {

        public static List<Cliente> listaDeClientes = new List<Cliente>
        {
            new Cliente { Codigo = 1, Nome = "José", Email = "jose@josemail.com", Senha = "pirulito123"},
            new Cliente { Codigo = 2, Nome = "Joao", Email = "joao@joaomail.com", Senha = "pirulito123"}
        };
        //get login
        public ActionResult Login()
        {
            return View();
        }

        /*post login
        public ActionResult Login(int? cod, string pass)
        {
            Cliente clientes = listaDeClientes.Find(x => x.Codigo == cod);//instancia um cliente do tipo cliente e procura o codigo na lista
            if (clientes == null)//se o cliente for nulo retorna pagina que não existe
            {
                return HttpNotFound();
            }
            return View(clientes);
        }
        */
        //GET CADASTRO
        public ActionResult Cadastro()
        {
            return View();
        }
        public ActionResult loginA(int? cod)
        {
            Cliente clientes = listaDeClientes.Find(x => x.Codigo == cod);//instancia um cliente do tipo cliente e procura o codigo na lista
            if (clientes == null)//se o cliente for nulo retorna pagina que não existe
            {
                return HttpNotFound();
            }
            return View(clientes);
        }
        

        // WYD > MU

        // GET: Usuarios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cliente clientes = listaDeClientes.Find(x => x.Codigo == id);//instancia um cliente do tipo cliente e procura o codigo na lista
            if (clientes == null)//se o cliente for nulo retorna pagina que não existe
            {
                return HttpNotFound();
            }
            return View(clientes);
        }

        // GET: Usuarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuarios/Create
        [HttpPost]
        public ActionResult Create(Cliente clientes)
        {
            try
            {
                listaDeClientes.Add(clientes);//add um cliente na lista
                return RedirectToAction("Index_U");// redireciona para a index

                return RedirectToAction("Index_U");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuarios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cliente clientes = listaDeClientes.Find(x => x.Codigo == id);
            if (clientes == null)
            {
                return HttpNotFound();
            }
            return View(clientes);
        }

        // POST: Usuarios/Edit/5
        [HttpPost]
        public ActionResult Edit(Cliente clientess)
        {
            try
            {
                Cliente clientes = listaDeClientes.Find(x => x.Codigo == clientess.Codigo);
                clientes.Codigo = clientess.Codigo;
                clientes.Nome = clientess.Nome;
                clientes.Email = clientess.Email;
                clientes.Senha = clientess.Senha;

                return RedirectToAction("Index");
            }
            catch
            {
                //Redireciona para a página de erro
                return View();
            }
        }

        // GET: Usuarios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cliente clientes = listaDeClientes.Find(x => x.Codigo == id);
            if (clientes == null)
            {
                return HttpNotFound();
            }
            return View(clientes);
        }

        // POST: Usuarios/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Cliente clientes = listaDeClientes.Find(x => x.Codigo == id);
                listaDeClientes.Remove(clientes);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
