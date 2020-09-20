using Business;
using Entities;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TFI.Controllers
{
    public class ReciboSueldoController : Controller
    {
        // GET: ReciboSueldo
        public ActionResult Index()
        {

            return View();
        }

        // GET: ReciboSueldo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ReciboSueldo/Create
        public ActionResult Create()
        {
            ReciboSueldo reciboSueldo = new ReciboSueldo();
            EmpleadoComponent empleado = new EmpleadoComponent();
            reciboSueldo.listaEmpleado = empleado.Read();
            reciboSueldo.listaEmpleado.Select(y =>
                                new
                                {
                                    y.Id,
                                    y.cuil
                                });

            ViewBag.ListaCategoria = new SelectList(reciboSueldo.listaEmpleado, "Id", "cuil");
                
              
            return View(reciboSueldo);
        }

        // POST: ReciboSueldo/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                ReciboSueldo reciboSueldo = new ReciboSueldo();
                ReciboSueldoComponent reciboSueldoComponent = new ReciboSueldoComponent(); 
                reciboSueldo.empleado.Id = int.Parse(collection.Get("empleado.cuil"));
                reciboSueldo.liquidacion = collection.Get("liquidacion");
                reciboSueldo.mes = int.Parse(collection.Get("mes"));
                reciboSueldo.año = int.Parse(collection.Get("año"));
                reciboSueldo.sueldo = int.Parse(collection.Get("sueldo"));
                reciboSueldo.lugar = collection.Get("lugar");
                reciboSueldo.fechaPago = collection.Get("fechaPago");

                reciboSueldoComponent.Create(reciboSueldo);
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: ReciboSueldo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReciboSueldo/Edit/5
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

        // GET: ReciboSueldo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReciboSueldo/Delete/5
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
