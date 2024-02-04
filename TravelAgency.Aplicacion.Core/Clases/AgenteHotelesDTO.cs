using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Aplicacion.Core
{
    public class AgenteHotelesDTO
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdAgennteHotel { get; set; }
        public int IdHabitacion { get; set; }
        public int IdEstadoHotel { get; set; }
        public int IdEstadoHabitacion { get; set; }
        public int IdHotel { get; set; }
        public int IdAgente { get; set; }
    }
}
