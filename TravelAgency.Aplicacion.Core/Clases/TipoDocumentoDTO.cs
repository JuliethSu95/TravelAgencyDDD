using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TravelAgency.Aplicacion.Core
{
    public class TipoDocumentoDTO
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTipoDocumento { get; set; }
        public string NombreTipoDocumento { get; set; }
    }
}
