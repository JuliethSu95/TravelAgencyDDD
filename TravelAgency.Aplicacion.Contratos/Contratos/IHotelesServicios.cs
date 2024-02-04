using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Aplicacion.Core;

namespace TravelAgency.Aplicacion.Contratos
{
    public interface IHotelesServicios : IDisposable
    {
        HotelesDTO ObtenerId(int id);
        //IEnumerable<AgenteDTO> Buscar(Expression<Func<AgenteDTO, bool>> predicado);
        IEnumerable<HotelesDTO> ObtenerTodos();
        bool Crear(HotelesDTO entidad);
        bool Eliminar(HotelesDTO entidad);
    }
}
