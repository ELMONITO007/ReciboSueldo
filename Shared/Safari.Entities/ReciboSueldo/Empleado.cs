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
  public  class Empleado : EntityBase
    {
        [DataMember]
        [DisplayName("Legajo")]
        public override int Id { get; set; }

        [DataMember]
        [DisplayName("Nombre")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, MinimumLength = 3,
         ErrorMessage = "Debe tener al menos 3 Carácteres y no superar los 50 Carácteres")]
        [DataType(DataType.Text, ErrorMessage = "Solo ingrese Texto")]
        public string nombre { get; set; }

        [DataMember]
        [DisplayName("Apellido")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, MinimumLength = 3,
         ErrorMessage = "Debe tener al menos 3 Carácteres y no superar los 50 Carácteres")]
        [DataType(DataType.Text, ErrorMessage = "Solo ingrese Texto")]
        public string apellido { get; set; }




        [DataMember]
        [DisplayName("Fecha de Ingreso")]
        [Required(ErrorMessage = "{0} is required")]

        [DataType(DataType.Date, ErrorMessage = "Formato de fecha incorrecta")]
        public DateTime fechaIngreso { get; set; }



        [DataMember]
        [DisplayName("CUIL")]
        [RegularExpression("/^([0-9]{11}|[0-9]{2}-[0-9]{8}-[0-9]{1})$", ErrorMessage = "CUIT Invalido")]
        [Required]

        public long cuil { get; set; }



        [DataMember]
        [DisplayName("Banco")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, MinimumLength = 3,
         ErrorMessage = "Debe tener al menos 3 Carácteres y no superar los 50 Carácteres")]
        [DataType(DataType.Text, ErrorMessage = "Solo ingrese Texto")]
        public string banco { get; set; }

        [DataMember]
        [DisplayName("Cuenta")]
        [RegularExpression("/^[0-9]{11}$", ErrorMessage = "debe tener 11 numeros")]
        [Required]

        public long cuenta { get; set; }


        public Empresa empresa { get; set; }
        public Categoria categoria { get; set; }
        public Departamento departamento { get; set; }
        public Division division { get; set; }


        public Empleado()
        {
            empresa = new Empresa();
            categoria = new Categoria();
            departamento = new Departamento();
            division = new Division();
        }

    }
}
