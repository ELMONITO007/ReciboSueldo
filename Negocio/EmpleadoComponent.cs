using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class EmpleadoComponent : Component<Empleado>
    {
        public override Empleado Create(Empleado objeto)
        {
            if (Verificar(objeto))
            {
                EmpleadoDAC empleadoComponent = new EmpleadoDAC();
                return empleadoComponent.Create(objeto);
            }
            else
            {
                return null;
            }
        }

        public override void Delete(int id)
        {
            EmpleadoDAC empleadoComponent = new EmpleadoDAC();
             empleadoComponent.Delete(id);
        }

        public override List<Empleado> Read()
        {
            EmpleadoDAC empleadoComponent = new EmpleadoDAC();
            List<Empleado> listaEmpleado = new List<Empleado>();
            List<Empleado> result = new List<Empleado>();
            listaEmpleado = empleadoComponent.Read();
            foreach (Empleado item in listaEmpleado)
            { Empleado empleado = new Empleado();
                CategoriaComponent categoriaComponent = new CategoriaComponent();
                empleado = item;
                empleado.categoria = categoriaComponent.ReadBy(item.categoria.Id);
                DepartamentoComponent departamento = new DepartamentoComponent();
                empleado.departamento = departamento.ReadBy(item.departamento.Id);
                DivisionComponent division = new DivisionComponent();
                empleado.division = division.ReadBy(item.division.Id);
                EmpresaComponent empresa = new EmpresaComponent();
                empleado.empresa = empresa.ReadBy(item.empresa.Id);

                result.Add(empleado);
            }

            return result;
        }

        public override Empleado ReadBy(int id)
        {
            EmpleadoDAC empleadoComponent = new EmpleadoDAC();
            Empleado listaEmpleado = new Empleado();
           
            listaEmpleado = empleadoComponent.ReadBy(id);
          
                Empleado empleado = new Empleado();
                CategoriaComponent categoriaComponent = new CategoriaComponent();
                empleado = listaEmpleado;
                empleado.categoria = categoriaComponent.ReadBy(listaEmpleado.categoria.Id);
                DepartamentoComponent departamento = new DepartamentoComponent();
                empleado.departamento = departamento.ReadBy(listaEmpleado.departamento.Id);
                DivisionComponent division = new DivisionComponent();
                empleado.division = division.ReadBy(listaEmpleado.division.Id);
                EmpresaComponent empresa = new EmpresaComponent();
                empleado.empresa = empresa.ReadBy(listaEmpleado.empresa.Id);

            

            return empleado;
        }

        public override Empleado ReadBy(Empleado objeto)
        {
            EmpleadoDAC empleadoComponent = new EmpleadoDAC();
            Empleado listaEmpleado = new Empleado();

            listaEmpleado = empleadoComponent.ReadBy(objeto);
            if (listaEmpleado is null)
            {
                return null;
            }
            else
            {
                Empleado empleado = new Empleado();
                CategoriaComponent categoriaComponent = new CategoriaComponent();
                empleado = listaEmpleado;
                empleado.categoria = categoriaComponent.ReadBy(listaEmpleado.categoria.Id);
                DepartamentoComponent departamento = new DepartamentoComponent();
                empleado.departamento = departamento.ReadBy(listaEmpleado.departamento.Id);
                DivisionComponent division = new DivisionComponent();
                empleado.division = division.ReadBy(listaEmpleado.division.Id);
                EmpresaComponent empresa = new EmpresaComponent();
                empleado.empresa = empresa.ReadBy(listaEmpleado.empresa.Id);
                return empleado;
            }
            
        }

        public override void Update(Empleado objeto)
        {
         
                EmpleadoDAC empleadoComponent = new EmpleadoDAC();
                empleadoComponent.Update(objeto);
         
           
        }

        public override bool Verificar(Empleado objeto)
        {
            if (ReadBy(objeto) is null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
