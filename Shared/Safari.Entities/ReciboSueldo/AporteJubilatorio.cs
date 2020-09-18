using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;

namespace Entities
{
    [Serializable]
    [DataContract]
    public class AporteJubilatorio : EntityBase
    {
        [DataMember]
        [DisplayName("Id")]
        public override int Id { get; set; }

        [DataMember]
        [DisplayName("Periodo")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, MinimumLength = 3,
        ErrorMessage = "Debe tener al menos 3 Carácteres y no superar los 50 Carácteres")]
        [DataType(DataType.Text,ErrorMessage ="Solo ingrese Texto")]
        public string periodo { get; set; }


        [DataMember]
        [DisplayName("Fecha")]
        [Required(ErrorMessage = "{0} is required")]
       
        [DataType(DataType.Date, ErrorMessage = "Formato de fecha incorrecta")]
        public DateTime fecha { get; set; }

        [DataMember]
        [DisplayName("Banco")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, MinimumLength = 3,
        ErrorMessage = "Debe tener al menos 3 Carácteres y no superar los 50 Carácteres")]
        [DataType(DataType.Text, ErrorMessage = "Solo ingrese Texto")]
        public string banco { get; set; }

        public List<AporteJubilatorio> ListaAporteJubilatorio { get; set; }
        public Empleado empleado { get; set; }


        public AporteJubilatorio()
        {
            ListaAporteJubilatorio = new List<AporteJubilatorio>();
            empleado = new Empleado();
        }


    }
}
