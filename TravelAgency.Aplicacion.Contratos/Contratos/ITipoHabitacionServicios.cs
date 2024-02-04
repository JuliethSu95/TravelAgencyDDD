using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Aplicacion.Core;

namespace TravelAgency.Aplicacion.Contratos
{
    public interface ITipoHabitacionServicios : IDisposable
    {
        TipoHabitacionDTO ObtenerId(int id);
        //IEnumerable<AgenteDTO> Buscar(Expression<Func<AgenteDTO, bool>> predicado);
        IEnumerable<TipoHabitacionDTO> ObtenerTodos();
        bool Crear(TipoHabitacionDTO entidad);
        bool Eliminar(TipoHabitacionDTO entidad);
    }
}
