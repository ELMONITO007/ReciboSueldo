using Business;
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
        public ReciboSueldo ReadByLegajo(int id)
        {
            ReciboSueldoDAC reciboSueldoComponent = new ReciboSueldoDAC();
            ReciboSueldo reciboSueldo = new ReciboSueldo();
            reciboSueldo.listaReciboSueldo = reciboSueldoComponent.ReadByLegajo(id);

            EmpleadoComponent empleadoComponent = new EmpleadoComponent();
            if (reciboSueldo.listaReciboSueldo.Count!=0)
            {
                reciboSueldo.empleado = empleadoComponent.ReadBy(reciboSueldo.listaReciboSueldo[0].empleado.Id);
            }
           

            return reciboSueldo;
        }

        public override ReciboSueldo ReadBy(ReciboSueldo objeto)
        {
            ReciboSueldoDAC reciboSueldoComponent = new ReciboSueldoDAC();
            ReciboSueldo reciboSueldo = new ReciboSueldo();
            reciboSueldo = reciboSueldoComponent.ReadBy(objeto);
            EmpleadoComponent empleadoComponent = new EmpleadoComponent();
            reciboSueldo.empleado = empleadoComponent.ReadBy(reciboSueldo.empleado.Id);
            LegajoItemComponent legajoItemComponent = new LegajoItemComponent();
            LegajoItem item = new LegajoItem();
            item.ReciboSueldo.Id = objeto.Id;
            reciboSueldo.listaItem = legajoItemComponent.Obtener(item);
            foreach (LegajoItem unItem in reciboSueldo.listaItem)
            {
                if (unItem.item.Tipo.tipoItem=="Retencion")
                {
                    reciboSueldo.totalRetencion = reciboSueldo.totalRetencion + unItem.valor;
                }
                else if (unItem.item.Tipo.tipoItem == "Exentas")
                {
                    reciboSueldo.totalExenta=reciboSueldo.totalExenta + unItem.valor;
                }
                else if (unItem.item.Tipo.tipoItem == "Deducciones")
                {
                    reciboSueldo.totalDeducciones = reciboSueldo.totalDeducciones + unItem.valor;
                }

            }

            reciboSueldo.totalNeto = reciboSueldo.totalRetencion + reciboSueldo.totalExenta - reciboSueldo.totalDeducciones;


            return reciboSueldo;
        }

        public override void Update(ReciboSueldo objeto)
        {
            throw new NotImplementedException();
        }
        public  void Update(LegajoItem legajoItem)
        {

            throw new NotImplementedException();
        }
        public override bool Verificar(ReciboSueldo objeto)
        {
            throw new NotImplementedException();
        }
    }
}
