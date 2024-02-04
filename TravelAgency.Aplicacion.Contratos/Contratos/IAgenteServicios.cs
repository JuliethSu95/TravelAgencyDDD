using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Aplicacion.Core;

namespace TravelAgency.Aplicacion.Contratos
{
    public interface IAgenteServicios : IDisposable
    {
        AgenteDTO ObtenerId(int id);
        //IEnumerable<AgenteDTO> Buscar(Expression<Func<AgenteDTO, bool>> predicado);
        IEnumerable<AgenteDTO> ObtenerTodos();
        bool Crear(AgenteDTO entidad);
        bool Eliminar(AgenteDTO entidad);
    }
}
