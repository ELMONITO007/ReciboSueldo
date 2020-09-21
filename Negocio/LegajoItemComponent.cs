using DATA;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
  public  class LegajoItemComponent
    {

        public bool Agregar(LegajoItem legajoItem)

        { LegajoItemDAC legajoItemDAC = new LegajoItemDAC();
            LegajoItem legajo = new LegajoItem();
            ItemComponent item = new ItemComponent();
            ReciboSueldoComponent reciboSueldoComponent = new ReciboSueldoComponent();
            legajo.ReciboSueldo = reciboSueldoComponent.ReadBy(legajoItem.ReciboSueldo.Id);

            legajo.item = item.ReadBy(legajoItem.item.Id);
            if (legajo.item.porcentaje==0)
            {
                legajo.valor = legajo.ReciboSueldo.sueldo;
            }
            else
            {
                legajo.valor = (legajo.ReciboSueldo.sueldo * legajo.item.porcentaje) / 100;
            }
            return legajoItemDAC.Agregar(legajo);

        }

        public List<LegajoItem> Obtener(LegajoItem legajoItem)

        {
            LegajoItemDAC legajo = new LegajoItemDAC();
            return legajo.Obtener(legajoItem);

            }
        }
}
