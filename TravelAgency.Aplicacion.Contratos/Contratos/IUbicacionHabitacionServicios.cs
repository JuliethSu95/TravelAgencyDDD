using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Aplicacion.Core;

namespace TravelAgency.Aplicacion.Contratos
{
    public interface IUbicacionHabitacionServicios : IDisposable
    {
        UbicacionHabitacionDTO ObtenerId(int id);
        //IEnumerable<AgenteDTO> Buscar(Expression<Func<AgenteDTO, bool>> predicado);
        IEnumerable<UbicacionHabitacionDTO> ObtenerTodos();
        bool Crear(UbicacionHabitacionDTO entidad);
        bool Eliminar(UbicacionHabitacionDTO entidad);
    }
}
