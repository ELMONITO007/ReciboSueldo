using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business;
using Negocio;

namespace TFI.Controllers
{
    public class AporteJubilatorioController : Controller
    {
        // GET: AporteJubilatorio
        public ActionResult Index()
        {
            AporteJubilatorioComponent aporteJubilatorioComponent = new AporteJubilatorioComponent();
            return View(aporteJubilatorioComponent.Read());
        }

        // GET: AporteJubilatorio/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AporteJubilatorio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AporteJubilatorio/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AporteJubilatorio/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AporteJubilatorio/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AporteJubilatorio/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AporteJubilatorio/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
