using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Aplicacion.Core;

namespace TravelAgency.Aplicacion.Contratos
{
    public interface IHabitacionServicios : IDisposable
    {
        HabitacionDTO ObtenerId(int id);
        //IEnumerable<AgenteDTO> Buscar(Expression<Func<AgenteDTO, bool>> predicado);
        IEnumerable<HabitacionDTO> ObtenerTodos();
        bool Crear(HabitacionDTO entidad);
        bool Eliminar(HabitacionDTO entidad);
    }
}
