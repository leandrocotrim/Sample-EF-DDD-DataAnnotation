using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class EnderecosController : Controller
    {
        ISrvCliente _cliente;
        public EnderecosController()
        {
            _cliente = new SrvCliente();
        }
        // GET: Enderecos
        public ActionResult Index(Guid idCliente)
        {
            var model = _cliente.Find(idCliente);
            ViewBag.Cliente = model; 
            
            return View(model.Enderecos);
        }

        // GET: Enderecos/Details/5
        public ActionResult Details(Guid id)
        {
            return View(_cliente.FindEndereco(id));
        }

        // GET: Enderecos/Create
        public ActionResult Create(Guid idCliente)
        {
            //ViewBag.IdCliente = idCliente;
            return View();
        }

        // POST: Enderecos/Create
        [HttpPost]
        public ActionResult Create(Guid idCliente, Model.Endereco endereco)
        {
            try
            {
                var model = _cliente.Find(idCliente);
                model.Enderecos.Add(endereco);
                _cliente.Update(model);

                return RedirectToAction("Index", new { idCliente = idCliente });
            }
            catch
            {
                return View();
            }
        }

        // GET: Enderecos/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View(_cliente.FindEndereco(id));
        }

        // POST: Enderecos/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, Model.Endereco endereco)
        {
            try
            {
                var model = _cliente.FindEndereco(id);
                model.Bairro = endereco.Bairro;
                model.Cidade = endereco.Cidade;
                model.Numero = endereco.Numero;
                model.Rua = endereco.Rua;

                _cliente.UpdateEndereco(model);

                return RedirectToAction("Index", new { idCliente = endereco.IdCliente });
            }
            catch
            {
                return View();
            }
        }

        // GET: Enderecos/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(_cliente.FindEndereco(id));
        }

        // POST: Enderecos/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, Model.Endereco endereco)
        {
            try
            {
                _cliente.RemoveEndereco(id);
                return RedirectToAction("Index", new { idCliente = endereco.IdCliente });
            }
            catch
            {
                return View();
            }
        }
    }
}
