﻿using System;
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
    public  class Item : EntityBase
    {
        [DataMember]
        [DisplayName("Id")]
        public override int Id { get; set; }

        [DataMember]
        [DisplayName("Item")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, MinimumLength = 3,
        ErrorMessage = "Debe tener al menos 3 Carácteres y no superar los 50 Carácteres")]
        [DataType(DataType.Text, ErrorMessage = "Solo ingrese Texto")]

        public string item { get; set; }

       
        public TipoItem Tipo { get; set; }


  
        [DisplayName("Porcentaje")]
        [RegularExpression("/^[0-9]{2}$", ErrorMessage = "CUIT Invalido")]
        [Required]

        public int porcentaje { get; set; }

        public List<TipoItem> ListaTipo { get; set; }

        public Item()
        {
            Tipo = new TipoItem();
            ListaTipo = new List<TipoItem>() ;
        
        }

    }
}
