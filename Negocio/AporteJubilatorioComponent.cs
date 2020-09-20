using Business;
using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class AporteJubilatorioComponent : Component<AporteJubilatorio>
    {
        public override AporteJubilatorio Create(AporteJubilatorio objeto)
        {
            AporteJubilatorioDAC aporteJubilatorio = new AporteJubilatorioDAC();
            return aporteJubilatorio.Create(objeto);
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override List<AporteJubilatorio> Read()
        {
            AporteJubilatorioDAC aporteJubilatorio = new AporteJubilatorioDAC();
            List<AporteJubilatorio> lista = new List<AporteJubilatorio>();
            List<AporteJubilatorio> result = new List<AporteJubilatorio>();
            lista = aporteJubilatorio.Read();
            foreach (AporteJubilatorio item in lista)
            {
                AporteJubilatorio aporte = new AporteJubilatorio();
                aporte = item;
                EmpleadoComponent empleadoComponent = new EmpleadoComponent();
                aporte.empleado = empleadoComponent.ReadBy(item.empleado.Id);
                result.Add (aporte);
            }
            return result;
        }

        public override AporteJubilatorio ReadBy(int id)
        {
            AporteJubilatorioDAC aporteJubilatorio = new AporteJubilatorioDAC();
            return aporteJubilatorio.ReadBy(id);
        }

        public override AporteJubilatorio ReadBy(AporteJubilatorio objeto)
        {
            throw new NotImplementedException();
        }

        public override void Update(AporteJubilatorio objeto)
        {
            throw new NotImplementedException();
        }

        public override bool Verificar(AporteJubilatorio objeto)
        {
            throw new NotImplementedException();
        }
    }
}
