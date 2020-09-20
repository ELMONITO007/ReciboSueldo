using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class CategoriaComponent : Component<Categoria>
    {
        public override Categoria Create(Categoria objeto)
        {
            if (Verificar(objeto))
            {
                CategoriaDAC categoriaDAC = new CategoriaDAC();
                return categoriaDAC.Create(objeto);
            }
            else
            {
                return null;
            }
        }

        public override void Delete(int id)
        {
            CategoriaDAC categoriaDAC = new CategoriaDAC();
             categoriaDAC.Delete(id);
        }

        public override List<Categoria> Read()
        {

            CategoriaDAC categoriaDAC = new CategoriaDAC();
            return categoriaDAC.Read();
        }

        public override Categoria ReadBy(int id)
        {
            CategoriaDAC categoriaDAC = new CategoriaDAC();
            return categoriaDAC.ReadBy(id);
        }

        public override Categoria ReadBy(Categoria objeto)
        {
            CategoriaDAC categoriaDAC = new CategoriaDAC();
            return categoriaDAC.ReadBy(objeto);
        }

        public override void Update(Categoria objeto)
        {
            if (Verificar(objeto))
            {
                CategoriaDAC categoriaDAC = new CategoriaDAC();
                categoriaDAC.Update(objeto);
            }
           
        }

        public override bool Verificar(Categoria objeto)
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
