using DATA;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ReciboSueldoComponent : Business.Component<ReciboSueldo>
    {
        public override ReciboSueldo Create(ReciboSueldo objeto)
        {

            ReciboSueldoDAC reciboSueldoDAC = new ReciboSueldoDAC();

            return reciboSueldoDAC.Create(objeto);

        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override List<ReciboSueldo> Read()
        {
            throw new NotImplementedException();
        }

        public override ReciboSueldo ReadBy(int id)
        {
            throw new NotImplementedException();
        }

        public override ReciboSueldo ReadBy(ReciboSueldo objeto)
        {
            throw new NotImplementedException();
        }

        public override void Update(ReciboSueldo objeto)
        {
            throw new NotImplementedException();
        }

        public override bool Verificar(ReciboSueldo objeto)
        {
            throw new NotImplementedException();
        }
    }
}
