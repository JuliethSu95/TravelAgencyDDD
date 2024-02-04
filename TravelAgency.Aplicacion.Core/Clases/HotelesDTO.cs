using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Aplicacion.Core
{
    public class HotelesDTO
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdHotel { get; set; }

        [Required]
        public string Razon_Social { get; set; }
        [Required]
        public int IdTipoIdentificacion { get; set; }
        [Required]
        public string Identificacion { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public string Telefono { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
