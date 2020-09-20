using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entities;
using Negocio;
namespace TFI.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult Index()
        {
            ItemComponent itemComponent = new ItemComponent();
            return View(itemComponent.Read());
        }

      

        // GET: Item/Create
        public ActionResult Create()
        {
            Item item = new Item();
            TipoItemComponent tipoItemComponent = new TipoItemComponent();
            item.ListaTipo = tipoItemComponent.Read();
           item.ListaTipo.Select(y =>
                                new
                                {
                                   y.Id,
                                   y.tipoItem
                                });
            ViewBag.ListaCategoria = new SelectList(item.ListaTipo, "Id", "tipoItem");

            return View(item);
        }

        // POST: Item/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                ItemComponent itemComponent = new ItemComponent();
                Item item = new Item();
                item.porcentaje = int.Parse(collection.Get("porcentaje"));
                item.item = collection.Get("item");
                item.Tipo.Id = int.Parse(collection.Get("Tipo.tipoItem"));
                itemComponent.Create(item);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: Item/Edit/5
        public ActionResult Edit(int id)
        {
            Item item = new Item();

            ItemComponent itemComponent = new ItemComponent();
            TipoItemComponent tipoItemComponent = new TipoItemComponent();
            item = itemComponent.ReadBy(id);
            item.ListaTipo = tipoItemComponent.Read();
            item.ListaTipo.Select(y =>
                                 new
                                 {
                                     y.Id,
                                     y.tipoItem
                                 });
            ViewBag.ListaCategoria = new SelectList(item.ListaTipo, "Id", "tipoItem");



            return View(item);
        }

        // POST: Item/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                ItemComponent itemComponent = new ItemComponent();
                Item item = new Item();
                item.Id = id;
                item.porcentaje = int.Parse(collection.Get("porcentaje"));
                item.item = collection.Get("item");
                item.Tipo.Id = int.Parse(collection.Get("Tipo.tipoItem"));
                itemComponent.Update(item);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: Item/Delete/5
        public ActionResult Delete(int id)
        {
            ItemComponent itemComponent = new ItemComponent();
            
            
            return View(itemComponent.ReadBy(id));
        }

        // POST: Item/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                ItemComponent itemComponent = new ItemComponent();
                itemComponent.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
