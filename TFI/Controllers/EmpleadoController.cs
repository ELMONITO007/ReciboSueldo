using Business;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TFI.Controllers
{
    public class EmpleadoController : Controller
    {
        //
        // GET: /Empleado/
        public ActionResult Index()
        {
            EmpleadoComponent empleadoComponent = new EmpleadoComponent();
            return View(empleadoComponent.Read());
        }

      
        // GET: /Empleado/Create
        public ActionResult Create()
        {
            Empleado empleado = new Empleado();
            CategoriaComponent categoriaComponent = new CategoriaComponent();
            DivisionComponent divisionComponent = new DivisionComponent();
            EmpresaComponent empresaComponent = new EmpresaComponent();
            DepartamentoComponent departamentoComponent = new DepartamentoComponent();
            empleado.listaCategoria = categoriaComponent.Read();
            empleado.listaDepartamento = departamentoComponent.Read();
            empleado.listaDivision = divisionComponent.Read();
            empleado.listaEmpresa = empresaComponent.Read();



           empleado.listaCategoria.Select(y =>
                                new
                                {
                                    y.Id,
                                    y.categoria
                                });

            ViewBag.ListaCategoria = new SelectList(empleado.listaCategoria, "Id", "categoria");





            empleado.listaDepartamento.Select(y =>
                                 new
                                 {
                                     y.Id,
                                     y.departamento
                                 });

            ViewBag.ListaDepartamento = new SelectList(empleado.listaDepartamento, "Id", "departamento");



            empleado.listaDivision.Select(y =>
                                 new
                                 {
                                     y.Id,
                                     y.division
                                 });

            ViewBag.ListaDivision = new SelectList(empleado.listaDivision, "Id", "division");


            empleado.listaEmpresa.Select(y =>
                               new
                               {
                                   y.Id,
                                   y.empresa
                               });

            ViewBag.ListaEmpresa = new SelectList(empleado.listaEmpresa, "Id", "empresa");

            return View(empleado);
        }

        //
        // POST: /Empleado/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    EmpleadoComponent empleadoComponent = new EmpleadoComponent();
                    Empleado empleado = new Empleado();
                    empleado.apellido = collection.Get("Apellido");
                    empleado.banco = collection.Get("banco");
                    empleado.categoria.Id =int.Parse( collection.Get("categoria.categoria"));
                    empleado.cuenta = collection.Get("cuenta");
                    empleado.cuil = collection.Get("cuil");
                    empleado.departamento.Id = int.Parse(collection.Get("departamento.departamento"));
                    empleado.division.Id = int.Parse(collection.Get("division.division"));
                    empleado.empresa.Id = int.Parse(collection.Get("empresa.empresa"));
                    empleado.fechaIngreso=DateTime.Parse( collection.Get("fechaIngreso"));
                    empleado.nombre= collection.Get("nombre");
                    if (empleadoComponent.Create(empleado) is null)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return RedirectToAction("Index");
                    }
                }
                else
                {
                    return RedirectToAction("Index");
                }
                
            }
            catch (Exception e)
            {
                return View();
            }
        }

        //
        // GET: /Empleado/Edit/5
        public ActionResult Edit(int id)
        {
            Empleado empleado = new Empleado();
            CategoriaComponent categoriaComponent = new CategoriaComponent();
            DivisionComponent divisionComponent = new DivisionComponent();
            EmpresaComponent empresaComponent = new EmpresaComponent();
            DepartamentoComponent departamentoComponent = new DepartamentoComponent();
            EmpleadoComponent empleadoComponent = new EmpleadoComponent();
            empleado = empleadoComponent.ReadBy(id);
            empleado.listaCategoria = categoriaComponent.Read();
            empleado.listaDepartamento = departamentoComponent.Read();
            empleado.listaDivision = divisionComponent.Read();
            empleado.listaEmpresa = empresaComponent.Read();



            empleado.listaCategoria.Select(y =>
                                 new
                                 {
                                     y.Id,
                                     y.categoria
                                 });

            ViewBag.ListaCategoria = new SelectList(empleado.listaCategoria, "Id", "categoria");





            empleado.listaDepartamento.Select(y =>
                                 new
                                 {
                                     y.Id,
                                     y.departamento
                                 });

            ViewBag.ListaDepartamento = new SelectList(empleado.listaDepartamento, "Id", "departamento");



            empleado.listaDivision.Select(y =>
                                 new
                                 {
                                     y.Id,
                                     y.division
                                 });

            ViewBag.ListaDivision = new SelectList(empleado.listaDivision, "Id", "division");


            empleado.listaEmpresa.Select(y =>
                               new
                               {
                                   y.Id,
                                   y.empresa
                               });

            ViewBag.ListaEmpresa = new SelectList(empleado.listaEmpresa, "Id", "empresa");

            return View(empleado);
        }

        //
        // POST: /Empleado/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    EmpleadoComponent empleadoComponent = new EmpleadoComponent();
                    Empleado empleado = new Empleado();
                    empleado.apellido = collection.Get("Apellido");
                    empleado.banco = collection.Get("banco");
                    empleado.categoria.Id = int.Parse(collection.Get("categoria.categoria"));
                    empleado.cuenta = collection.Get("cuenta");
                    empleado.cuil = collection.Get("cuil");
                    empleado.departamento.Id = int.Parse(collection.Get("departamento.departamento"));
                    empleado.division.Id = int.Parse(collection.Get("division.division"));
                    empleado.empresa.Id = int.Parse(collection.Get("empresa.empresa"));
                    empleado.fechaIngreso = DateTime.Parse(collection.Get("fechaIngreso"));
                    empleado.nombre = collection.Get("nombre");
                    empleado.Id = id;
                    empleadoComponent.Update(empleado);
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("Index");
                }
               
            }
            catch (Exception e)
            {
                return View();
            }
        }

        //
        // GET: /Empleado/Delete/5
        public ActionResult Delete(int id)
        {
            EmpleadoComponent empleadoComponent = new EmpleadoComponent();

            return View(empleadoComponent.ReadBy(id));
        }

        //
        // POST: /Empleado/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                EmpleadoComponent empleadoComponent = new EmpleadoComponent();
                empleadoComponent.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
