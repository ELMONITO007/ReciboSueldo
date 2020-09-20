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
    public class TipoItemComponent : Component<TipoItem>
    {
        public override TipoItem Create(TipoItem objeto)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override List<TipoItem> Read()
        {
            TipoItemDAC tipoItemDAC = new TipoItemDAC();
            return tipoItemDAC.Read();
        }

        public override TipoItem ReadBy(int id)
        {
            TipoItemDAC tipoItemDAC = new TipoItemDAC();
            return tipoItemDAC.ReadBy(id);
        }

        public override TipoItem ReadBy(TipoItem objeto)
        {
            throw new NotImplementedException();
        }

        public override void Update(TipoItem objeto)
        {
            throw new NotImplementedException();
        }

        public override bool Verificar(TipoItem objeto)
        {
            throw new NotImplementedException();
        }
    }
}
