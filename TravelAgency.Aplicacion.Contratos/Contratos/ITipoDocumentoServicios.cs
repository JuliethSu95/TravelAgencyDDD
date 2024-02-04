using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Aplicacion.Core;

namespace TravelAgency.Aplicacion.Contratos
{
    public interface ITipoDocumentoServicios : IDisposable
    {
        TipoDocumentoDTO ObtenerId(int id);
        //IEnumerable<AgenteDTO> Buscar(Expression<Func<AgenteDTO, bool>> predicado);
        IEnumerable<TipoDocumentoDTO> ObtenerTodos();
        bool Crear(TipoDocumentoDTO entidad);
        bool Eliminar(TipoDocumentoDTO entidad);
    }
}
