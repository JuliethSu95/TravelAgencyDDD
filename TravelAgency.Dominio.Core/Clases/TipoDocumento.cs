using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TravelAgency.Dominio.Core
{
    public class TipoDocumento
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTipoDocumento { get; set; }
        public string NombreTipoDocumento { get; set; }
    }
}

