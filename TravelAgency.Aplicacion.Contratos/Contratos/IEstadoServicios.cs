using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Aplicacion.Core;

namespace TravelAgency.Aplicacion.Contratos
{
    public interface IEstadoServicios : IDisposable
    {
        EstadoDTO ObtenerId(int id);
        //IEnumerable<AgenteDTO> Buscar(Expression<Func<AgenteDTO, bool>> predicado);
        IEnumerable<EstadoDTO> ObtenerTodos();
        bool Crear(EstadoDTO entidad);
        bool Eliminar(EstadoDTO entidad);
    }
}
