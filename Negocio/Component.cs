using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business
{
   public abstract class Component<T>
    {
        public abstract bool Verificar(T objeto);
        public abstract T Create(T objeto);
        public abstract List<T> Read();
        public abstract T ReadBy(int id);
        public abstract T ReadBy(T objeto);
        public abstract void Update(T objeto);

        public abstract void Delete(int id);

    }
}
