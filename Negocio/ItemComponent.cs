using Business;
using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ItemComponent : Component<Item>
    {
        public override Item Create(Item objeto)
        {
            if (Verificar(objeto))
            {
                ItemDAC itemDAC = new ItemDAC();
                return itemDAC.Create(objeto);
            }
            else
            {
                return null;
            }

        }

        public override void Delete(int id)
        {
            ItemDAC itemDAC = new ItemDAC();
             itemDAC.Delete(id);
        }

        public override List<Item> Read()
        {
            ItemDAC itemDAC = new ItemDAC();
            List<Item> item = new List<Item>();
            List<Item> result = new List<Item>();
            item = itemDAC.Read();
            foreach (Item i in item)
            {
                Item unItem = new Item();
                unItem = i;
                TipoItemComponent tipoItemComponent = new TipoItemComponent();
                unItem.Tipo = tipoItemComponent.ReadBy(i.Tipo.Id);
                result.Add(unItem);
            }
            return result;
        }

        public override Item ReadBy(int id)
        {
            ItemDAC itemDAC = new ItemDAC();
            Item item = new Item();
            item= itemDAC.ReadBy(id);
            TipoItemComponent tipoItemComponent = new TipoItemComponent();
            item.Tipo = tipoItemComponent.ReadBy(item.Tipo.Id);
            return item;
        }

        public override Item ReadBy(Item objeto)
        {

            ItemDAC itemDAC = new ItemDAC();
            Item item = new Item();
            item = itemDAC.ReadBy(objeto);
            if (item is null)
            {
                return null;
            }
            else
            {
                TipoItemComponent tipoItemComponent = new TipoItemComponent();
                item.Tipo = tipoItemComponent.ReadBy(item.Tipo.Id);
                return item;
            }
           
        }

        public override void Update(Item objeto)
        {
           
                ItemDAC itemDAC = new ItemDAC();
                itemDAC.Update(objeto);
            
           
        }

        public override bool Verificar(Item objeto)
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
