using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Aplicacion.Core;
using TravelAgency.Dominio.Core;

namespace TravelAgency.Aplicacion.Contratos
{
    public interface IAgenteHotelesServicios : IDisposable
    {
        AgenteHotelesDTO ObtenerId(int id);
        //IEnumerable<AgenteDTO> Buscar(Expression<Func<AgenteDTO, bool>> predicado);
        IEnumerable<AgenteHotelesDTO> ObtenerTodos();
        bool Crear(AgenteHotelesDTO entidad);
        bool Eliminar(AgenteHotelesDTO entidad);
    }
}
