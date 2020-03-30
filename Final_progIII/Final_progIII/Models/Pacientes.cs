using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Final_progIII.Models
{
    public class Pacientes
    {


        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Cedula { get; set; }
        [Required]
        [StringLength(200)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(100)]
        public bool Asegurado { get; set; }


    }
}