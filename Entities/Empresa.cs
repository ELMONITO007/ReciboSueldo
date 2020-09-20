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
    public class Empresa : EntityBase
    {
        [DataMember]
        [DisplayName("Id")]
        public override int Id { get; set; }

        [DataMember]
        [DisplayName("Empresa")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, MinimumLength = 3,
         ErrorMessage = "Debe tener al menos 3 Carácteres y no superar los 50 Carácteres")]
        [DataType(DataType.Text, ErrorMessage = "Solo ingrese Texto")]
        public string empresa { get; set; }


        [DataMember]
        [DisplayName("Direccion")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, MinimumLength = 3,
         ErrorMessage = "Debe tener al menos 3 Carácteres y no superar los 50 Carácteres")]
        public string direccion { get; set; }


        [DataMember]
        [DisplayName("CUIT")]
     [RegularExpression("/^([0-9]{11}|[0-9]{2}-[0-9]{8}-[0-9]{1})$",ErrorMessage ="CUIT Invalido")]
        [Required]

        public string cuit { get; set; }



    }
}
