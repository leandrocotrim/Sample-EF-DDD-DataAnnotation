using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class ClienteController : Controller
    {
        ISrvCliente _cliente;
        public ClienteController()
        {
            _cliente = new SrvCliente();
        }
        // GET: Cliente
        public ActionResult Index()
        {
            return View(_cliente.List());
        }

        // GET: Cliente/Details/5
        public ActionResult Details(Guid id)
        {
            return View(_cliente.Find(id));
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Create(Model.Cliente cliente)
        {
            try
            {
                _cliente.Add(cliente);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View(_cliente.Find(id));
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, Model.Cliente cliente)
        {
            try
            {
                var model = _cliente.Find(id);
                model.Idade = cliente.Idade;
                model.Nome = cliente.Nome;
                model.Profissao = cliente.Profissao;

                _cliente.Update(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(_cliente.Find(id));
        }

        // POST: Cliente/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, Model.Cliente cliente)
        {
            try
            {
                _cliente.Remove(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
