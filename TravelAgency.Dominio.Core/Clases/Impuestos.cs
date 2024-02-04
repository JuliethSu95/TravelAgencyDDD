using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Dominio.Core
{
    public class Impuestos
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdImpuesto { get; set; }

        public string TipoImpuesto { get; set; }

        public string NombreImpuesto { get; set; }

        public decimal Porcentaje { get; set; }

        public decimal Base { get; set; }
    }
}
