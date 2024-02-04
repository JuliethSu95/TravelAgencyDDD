using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Dominio.Core
{
    public interface IRepositorioBase<Entidad> : IDisposable
    {
        IUnidadTrabajo UnidadTrabajo { get; }

        Entidad ObtenerId(int id);
        //Entidad Buscar(Expression<Func<Entidad, bool>> predicado);
        IEnumerable<Entidad> ObtenerTodos();
        bool Crear(Entidad entidad);
        bool Eliminar(Entidad entidad);


    }
}
