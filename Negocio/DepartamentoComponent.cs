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
    public class DepartamentoComponent : Component<Departamento>
    {
        public override Departamento Create(Departamento objeto)
        {
            if (Verificar(objeto))
            {
                DepartamentoDAC departamentoDAC = new DepartamentoDAC();
                return departamentoDAC.Create(objeto);
            }
            else
            {
                return null;
            }
        }

        public override void Delete(int id)
        {
            DepartamentoDAC departamentoDAC = new DepartamentoDAC();
            departamentoDAC.Delete(id);
        }

        public override List<Departamento> Read()
        {
            DepartamentoDAC departamentoDAC = new DepartamentoDAC();
            return departamentoDAC.Read();
        }

        public override Departamento ReadBy(int id)
        {
            DepartamentoDAC departamentoDAC = new DepartamentoDAC();
            return departamentoDAC.ReadBy(id);
        }

        public override Departamento ReadBy(Departamento objeto)
        {
            DepartamentoDAC departamentoDAC = new DepartamentoDAC();
            return departamentoDAC.ReadBy(objeto);
        }

        public override void Update(Departamento objeto)
        {
            if (Verificar(objeto))
            {
                DepartamentoDAC departamentoDAC = new DepartamentoDAC();
                departamentoDAC.Update(objeto);
            }
        }

        public override bool Verificar(Departamento objeto)
        {
            if (ReadBy(objeto)is null)
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
