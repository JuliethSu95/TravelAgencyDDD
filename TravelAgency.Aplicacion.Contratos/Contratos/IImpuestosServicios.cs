using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Aplicacion.Core;

namespace TravelAgency.Aplicacion.Contratos
{
    public interface IImpuestosServicios : IDisposable
    {
        ImpuestosDTO ObtenerId(int id);
        //IEnumerable<AgenteDTO> Buscar(Expression<Func<AgenteDTO, bool>> predicado);
        IEnumerable<ImpuestosDTO> ObtenerTodos();
        bool Crear(ImpuestosDTO entidad);
        bool Eliminar(ImpuestosDTO entidad);
    }
}
