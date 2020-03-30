using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Final_progIII.Models
{
    public class Medicos
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(200)]
        public string Exequatur { get; set; }
        [Required]
        [StringLength(100)]
        public string Especialidad { get; set; }

    }
}