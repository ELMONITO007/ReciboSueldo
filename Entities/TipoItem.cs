using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
  public  class TipoItem :EntityBase
    {
        [DisplayName("Id")]
        public override int Id { get; set; }

        [DisplayName("Tipo de Item")]
        public string tipoItem { get; set; }
    }
}
