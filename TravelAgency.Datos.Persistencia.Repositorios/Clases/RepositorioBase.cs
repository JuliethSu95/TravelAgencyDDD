using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Datos.Persistencia.Core;
using TravelAgency.Dominio.Core;

namespace TravelAgency.Datos.Persistencia.Repositorios
{
    public class RepositorioBase<Entidad> : IRepositorioBase<Entidad> where Entidad : class
    {
        readonly IContextoUnidadTrabajo _contextoUnidadTrabajo;

        public IUnidadTrabajo UnidadTrabajo { get { return _contextoUnidadTrabajo; } }

        public RepositorioBase(IContextoUnidadTrabajo contextoUnidadTrabajo)
        {
            this._contextoUnidadTrabajo = contextoUnidadTrabajo;
        }

        public Entidad ObtenerId(int id)
        {
            return _contextoUnidadTrabajo.Set<Entidad>().Find(id);
        }

        public IEnumerable<Entidad> Buscar(Expression<Func<Entidad, bool>> predicado) 
        {
            return _contextoUnidadTrabajo.Set<Entidad>().Where(predicado);
        }
      
        public IEnumerable<Entidad> ObtenerTodos() 
        {
            return _contextoUnidadTrabajo.Set<Entidad>().ToList();
        }
        public bool Crear(Entidad entidad) 
        {
            _contextoUnidadTrabajo.Set<Entidad>().Add(entidad);
            return true;
        }
        public bool Eliminar(Entidad entidad) 
        {
            _contextoUnidadTrabajo.Set<Entidad>().Remove(entidad);
            return true;
        }
        public void Dispose()
        {
            _contextoUnidadTrabajo.Dispose();
        }
    }
}
