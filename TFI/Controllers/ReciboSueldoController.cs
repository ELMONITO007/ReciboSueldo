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
        public ActionResult Index(int id)
        {
            ReciboSueldoComponent reciboSueldo = new ReciboSueldoComponent();
            return View(reciboSueldo.ReadByLegajo(id));
        }

        // GET: ReciboSueldo/Details/5
        public ActionResult VerRecibo(int id)
        {
            ReciboSueldoComponent reciboSueldoComponent = new ReciboSueldoComponent();
            ReciboSueldo objeto = new ReciboSueldo();
            objeto.Id = id;

            return View(reciboSueldoComponent.ReadBy(objeto));
        }

        // GET: ReciboSueldo/Create
        public ActionResult Create(int id)
        {
            ReciboSueldo reciboSueldo = new ReciboSueldo();
            EmpleadoComponent empleado = new EmpleadoComponent();
            reciboSueldo.listaEmpleado = empleado.Read();
            reciboSueldo.empleado = empleado.ReadBy(id);
              
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
                reciboSueldo.empleado.Id = int.Parse(collection.Get("empleado.Id"));
                reciboSueldo.liquidacion = collection.Get("liquidacion");
                reciboSueldo.mes = int.Parse(collection.Get("mes"));
                reciboSueldo.año = int.Parse(collection.Get("año"));
                reciboSueldo.sueldo = int.Parse(collection.Get("sueldo"));
                reciboSueldo.lugar = collection.Get("lugar");
                reciboSueldo.fechaPago = collection.Get("fechaPago");

                reciboSueldoComponent.Create(reciboSueldo);
                // TODO: Add insert logic here

                return RedirectToAction("Index",new { id = reciboSueldo.empleado.Id });
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
