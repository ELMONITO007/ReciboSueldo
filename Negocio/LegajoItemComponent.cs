
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
            legajo.ReciboSueldo = reciboSueldoComponent.ReadByLegajo(legajoItem.ReciboSueldo.Id);

            legajo.item = item.ReadBy(legajoItem.item.Id);
            if (legajo.item.porcentaje==0)
            {
                legajo.valor = legajo.ReciboSueldo.listaReciboSueldo[0].sueldo;
            }
            else
            {
                legajo.valor = (legajo.ReciboSueldo.listaReciboSueldo[0].sueldo * legajo.item.porcentaje) / 100;
            }
            return legajoItemDAC.Agregar(legajo);

        }

        public List<LegajoItem> Obtener(LegajoItem legajoItem)

        {
            LegajoItemDAC legajo = new LegajoItemDAC();
            List < LegajoItem> unaLegajo = new List<LegajoItem>();
            List<LegajoItem> result = new List<LegajoItem>();
            unaLegajo = legajo.Obtener(legajoItem);
            foreach (LegajoItem item in unaLegajo)
            {
                LegajoItem aux = new LegajoItem();
                aux.ReciboSueldo = item.ReciboSueldo;
                ItemComponent itemComponent = new ItemComponent();
                aux.item = itemComponent.ReadBy(item.item.Id);
                aux.valor = item.valor;
                result.Add(aux);
                     }

            return result;

            }
        public LegajoItem ObtenerFaltantes(LegajoItem legajoItem)

        {
            List<LegajoItem> listaLegajoItem = new List<LegajoItem>();
            listaLegajoItem = Obtener(legajoItem);
            ItemComponent itemComponent = new ItemComponent();
            List<Item> items = new List<Item>();
            items = itemComponent.Read();
          LegajoItem result = new LegajoItem();

            foreach (Item item in items)
            {
                int a = 0;
                foreach (LegajoItem subItem in listaLegajoItem)
                {
                    if (item.Id==subItem.item.Id)
                    {
                        a = 1;
                    }

                }
                if (a==0)
                {
                    result.ListaItem.Add(item);
                }

            }

            return result;


        }
    }


    
}
