using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Dominio.Core
{
    public  class HabitacionImpuestos
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdHabitacionImpuestos { get; set; }

        public int IdHabitacion { get; set; }

        public int IdTipoImpuestos { get; set; }

        public decimal CostoBase { get; set; }
    }

}
