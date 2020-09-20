using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Entities
{

    public class EmpleadoModel
    {

        [DisplayName("Legajo")]
        public  int Id { get; set; }

        [@RequiredAttribute]
        [DisplayName("Nombre")]
     public string nombre { get; set; }


        [Required]
        public string apellido { get; set; }




        [Required(ErrorMessage = "{0} is required")]
        
        public DateTime fechaIngreso { get; set; }


        [Required]
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
       
        public EmpleadoModel()
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
