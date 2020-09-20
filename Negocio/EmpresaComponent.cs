using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class EmpresaComponent : Component<Empresa>
    {
        public override Empresa Create(Empresa objeto)
        {
            if (Verificar(objeto))
            {
                EmpresaDAC empresaDAC = new EmpresaDAC();
                return empresaDAC.Create(objeto);
            }
            else
            {
                return null;
            }
           
        }

        public override void Delete(int id)
        {
            EmpresaDAC empresaDAC = new EmpresaDAC();
            empresaDAC.Delete(id);
        }

        public override List<Empresa> Read()
        {
            EmpresaDAC empresaDAC = new EmpresaDAC();
            return empresaDAC.Read();
        }

        public override Empresa ReadBy(int id)
        {
            EmpresaDAC empresaDAC = new EmpresaDAC();
            return empresaDAC.ReadBy(id);
        }

        public override Empresa ReadBy(Empresa objeto)
        {
            EmpresaDAC empresaDAC = new EmpresaDAC();
            return empresaDAC.ReadBy(objeto);
        }

        public override void Update(Empresa objeto)
        {
            if (Verificar(objeto))
            {
                EmpresaDAC empresaDAC = new EmpresaDAC();
                empresaDAC.Update(objeto);
            }
           
        }

        public override bool Verificar(Empresa objeto)
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
