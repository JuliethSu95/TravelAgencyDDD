using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Aplicacion.Contratos;
using TravelAgency.Aplicacion.Core;
using TravelAgency.Dominio.Contratos;
using TravelAgency.Dominio.Core;

namespace TravelAgency.Aplicacion.Implementacion
{
    public class TipoHabitacionServicio : ITipoHabitacionServicios
    {
        private ITipoHabitacionRepositorio _tipoHabitacionRepositorio;

        public TipoHabitacionServicio(ITipoHabitacionRepositorio tipoHabitacionRepositorio)
        {
            this._tipoHabitacionRepositorio = tipoHabitacionRepositorio;
        }

        public TipoHabitacionDTO ObtenerId(int id)
        {
            var objetoRecuperado = _tipoHabitacionRepositorio.ObtenerId(id);
            return Mapper.Map<TipoHabitacion, TipoHabitacionDTO>(objetoRecuperado);
        }
        public IEnumerable<TipoHabitacionDTO> ObtenerTodos()
        {
            var lista = _tipoHabitacionRepositorio.ObtenerTodos();
            return Mapper.Map<IEnumerable<TipoHabitacion>, IEnumerable<TipoHabitacionDTO>>(lista);
        }

        public bool Crear(TipoHabitacionDTO entidad)
        {
            try
            {
                var _objeto = new TipoHabitacion();
                Mapper.Map(entidad, _objeto);
                _tipoHabitacionRepositorio.Crear(_objeto);
                _tipoHabitacionRepositorio.UnidadTrabajo.Confirmar();
                return true;
            }
            catch
            {

                return false;
            }
        }
        public bool Eliminar(TipoHabitacionDTO entidad)
        {
            try
            {
                var _objeto = new TipoHabitacion();
                Mapper.Map(entidad, _objeto);
                _tipoHabitacionRepositorio.Eliminar(_objeto);
                _tipoHabitacionRepositorio.UnidadTrabajo.Confirmar();
                return true;
            }
            catch
            {

                return false;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_tipoHabitacionRepositorio != null)
                {
                    _tipoHabitacionRepositorio.Dispose();
                    _tipoHabitacionRepositorio = null;
                }
            }
        }


    }
}
