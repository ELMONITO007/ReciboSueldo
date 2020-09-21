using Entities;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TFI.Controllers
{
    public class LegajoItemController : Controller
    {
        // GET: LegajoItem
        public ActionResult Index()
        {
            return View();
        }

        // GET: LegajoItem/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LegajoItem/Create
        public ActionResult Create(int id)
        {
            LegajoItem item = new LegajoItem();
            item.ReciboSueldo.Id = id;
            LegajoItemComponent legajoItemComponent = new LegajoItemComponent();
            LegajoItem result = new LegajoItem();
            result = legajoItemComponent.ObtenerFaltantes(item);
            result.ReciboSueldo.Id = id;
            result.ListaItem.Select(y =>
                                new
                                {
                                    y.Id,
                                    y.item
                                });

            ViewBag.ListaCategoria = new SelectList(result.ListaItem, "Id", "item");

              

            return View(result);
        }

        // POST: LegajoItem/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                LegajoItemComponent legajoItemComponent = new LegajoItemComponent();
                LegajoItem item = new LegajoItem();
                item.item.Id =int.Parse( collection.Get("item.item"));
                item.ReciboSueldo.Id= int.Parse(collection.Get("ReciboSueldo.Id"));
                legajoItemComponent.Agregar(item);
                // TODO: Add insert logic here

                return RedirectToAction("Index","ReciboSueldo",new { id = item.ReciboSueldo.Id });
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: LegajoItem/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LegajoItem/Edit/5
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

        // GET: LegajoItem/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LegajoItem/Delete/5
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
