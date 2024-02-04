using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Aplicacion.Core;

namespace TravelAgency.Aplicacion.Contratos
{
    public interface IHabitacionImpuestosServicios : IDisposable
    {
        HabitacionImpuestosDTO ObtenerId(int id);
        //IEnumerable<AgenteDTO> Buscar(Expression<Func<AgenteDTO, bool>> predicado);
        IEnumerable<HabitacionImpuestosDTO> ObtenerTodos();
        bool Crear(HabitacionImpuestosDTO entidad);
        bool Eliminar(HabitacionImpuestosDTO entidad);
    }
}
