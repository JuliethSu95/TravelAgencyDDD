﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Aplicacion.Core
{
    public class AgenteDTO
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdAgente { get; set; }
        [Required]
        public int IdTipoIdentificacion { get; set; }
        [Required]
        public string Identificacion { get; set; }
        [Required]
        public string NombreAgente { get; set; }
        [Required]
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }

    }
}