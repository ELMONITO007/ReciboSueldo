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
    public class DivisionComponent : Component<Division>
    {
        public override Division Create(Division objeto)
        {
            if (Verificar(objeto))
            {
                DivisionDAC divisionDAC = new DivisionDAC();
                return divisionDAC.Create(objeto);
            }
            else
            {
                return null;
            }
        }

        public override void Delete(int id)
        {
            DivisionDAC divisionDAC = new DivisionDAC();
             divisionDAC.Delete(id);
        }

        public override List<Division> Read()
        {
            DivisionDAC divisionDAC = new DivisionDAC();
            return divisionDAC.Read();
        }

        public override Division ReadBy(int id)
        {
            DivisionDAC divisionDAC = new DivisionDAC();
            return divisionDAC.ReadBy(id);
        }

        public override Division ReadBy(Division objeto)
        {
            DivisionDAC divisionDAC = new DivisionDAC();
            return divisionDAC.ReadBy(objeto); 
        }

        public override void Update(Division objeto)
        {
            if (Verificar(objeto))
            {
                DivisionDAC divisionDAC = new DivisionDAC();
                divisionDAC.Update(objeto);
            }
        }

        public override bool Verificar(Division objeto)
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
