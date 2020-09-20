using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;

namespace Entities
{

    public class Empleado : EntityBase
    {

        [DisplayName("Legajo")]
        public override int Id { get; set; }

       [Required]
        [DisplayName("Nombre")]
      
        //[StringLength(50, MinimumLength = 3,
        // ErrorMessage = "Debe tener al menos 3 Carácteres y no superar los 50 Carácteres")]
        //[DataType(DataType.Text, ErrorMessage = "Solo ingrese Texto")]
        public string nombre { get; set; }


        [Required(ErrorMessage = "{0} is required")]
        [DisplayName("Apellido")]
      
        [StringLength(50, MinimumLength = 3,
         ErrorMessage = "Debe tener al menos 3 Carácteres y no superar los 50 Carácteres")]
        [DataType(DataType.Text, ErrorMessage = "Solo ingrese Texto")]
        public string apellido { get; set; }




        [Required(ErrorMessage = "{0} is required")]
        [DisplayName("Fecha de Ingreso")]
       

        [DataType(DataType.Date, ErrorMessage = "Formato de fecha incorrecta")]
        public DateTime fechaIngreso { get; set; }


        [Required]
        [DisplayName("CUIL")]
        [RegularExpression("/^([0-9]{11}|[0-9]{2}-[0-9]{8}-[0-9]{1})$", ErrorMessage = "CUIT Invalido")]
    

        public string cuil { get; set; }


        [Required(ErrorMessage = "{0} is required")]

        [DisplayName("Banco")]
      
        [StringLength(50, MinimumLength = 3,
         ErrorMessage = "Debe tener al menos 3 Carácteres y no superar los 50 Carácteres")]
        [DataType(DataType.Text, ErrorMessage = "Solo ingrese Texto")]
        public string banco { get; set; }


        [Required]
      
        [DisplayName("Cuenta")]
        [RegularExpression("/^[0-9]{11}$", ErrorMessage = "debe tener 11 numeros")]
    

        public string cuenta { get; set; }


        public Empresa empresa { get; set; }
        public Categoria categoria { get; set; }
        public Departamento departamento { get; set; }
        public Division division { get; set; }


        public List<Empresa>  listaEmpresa { get; set; }
        public List<Categoria>listaCategoria { get; set; }
        public List<Departamento> listaDepartamento { get; set; }
        public List<Division> listaDivision { get; set; }
       
        public Empleado()
        {
            listaEmpresa = new List<Empresa>();
            listaDepartamento = new List<Departamento>();
            listaDivision = new List<Division>();
            listaCategoria = new List<Categoria>();
            empresa = new Empresa();
            categoria = new Categoria();
            departamento = new Departamento();
            division = new Division();
        }

    }
}
