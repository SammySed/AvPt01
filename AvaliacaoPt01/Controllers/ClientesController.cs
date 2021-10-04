using AvaliacaoPt01.Context;
using AvaliacaoPt01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AvaliacaoPt01.Controllers
{
    public class ClientesController : Controller
    {
        private EFContext context = new EFContext();

        // GET: Clientes
        public ActionResult Index()
        {
            return View(context.cliente.OrderBy(f => f.Nome));
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Cliente cliente)
        {
            context.cliente.Add(cliente);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}