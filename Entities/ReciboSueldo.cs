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
    public class ReciboSueldo : EntityBase
    {
        [DataMember]
        [DisplayName("Id")]
        public override int Id { get; set; }

        [DataMember]
        [DisplayName("Liquidacion")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, MinimumLength = 3,
        ErrorMessage = "Debe tener al menos 3 Carácteres y no superar los 50 Carácteres")]
        [DataType(DataType.Text, ErrorMessage = "Solo ingrese Texto")]
        public string liquidacion { get; set; }



        [DataMember]
        [DisplayName("Mes")]
        [RegularExpression("/^[0-9]{2}$", ErrorMessage = "Debe ingresar dos numeros")]
        [Required]

        public int mes { get; set; }

        [DataMember]
        [DisplayName("Año")]
        [RegularExpression("/^[0-9]{4}$", ErrorMessage = "Debe ingresar cuatro numeros")]
        [Required]

        public int año { get; set; }

        [DataMember]
        [DisplayName("Sueldo")]
        [RegularExpression("/^[0-9]{4,5,6,7,8}$", ErrorMessage = "Debe ingresar numeros, valor minimo 1000")]
        [Required]

        public int sueldo { get; set; }

        [DataMember]
        [DisplayName("Lugar")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, MinimumLength = 3,
       ErrorMessage = "Debe tener al menos 3 Carácteres y no superar los 50 Carácteres")]
        [DataType(DataType.Text, ErrorMessage = "Solo ingrese Texto")]
        public string lugar { get; set; }


        [DataMember]
        [DisplayName("Fecha de pago")]
        [Required(ErrorMessage = "{0} is required")]
        
        [DataType(DataType.Date, ErrorMessage = "Fecha invalida")]
        public string fechaPago { get; set; }



        [DataMember]
        [DisplayName("Total Retencion")]
        [RegularExpression("/^[0-9]$", ErrorMessage = "Debe ingresar numeros")]
        [Required]

        public int totalRetencion { get; set; }



        [DataMember]
        [DisplayName("Total Exento")]
        [RegularExpression("/^[0-9]$", ErrorMessage = "Debe ingresar numeros")]
        [Required]

        public int totalExenta { get; set; }


        [DataMember]
        [DisplayName("Total Deducciones")]
        [RegularExpression("/^[0-9]$", ErrorMessage = "Debe ingresar numeros")]
        [Required]

        public int totalDeducciones { get; set; }


        [DataMember]
        [DisplayName("Total Neto")]
        [RegularExpression("/^[0-9]$", ErrorMessage = "Debe ingresar numeros")]
        [Required]

        public int totalNeto { get; set; }

        public Empleado empleado { get; set; }
        public List<Item> listaItem { get; set; }
        public List<Empleado> listaEmpleado { get; set; }
        public ReciboSueldo()
        {
            listaEmpleado = new List<Empleado>();
            listaItem = new List<Item>();
          empleado = new Empleado(); 
        
        }
    }
}
