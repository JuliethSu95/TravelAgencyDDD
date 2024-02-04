using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Aplicacion.Contratos;
using TravelAgency.Aplicacion.Core;
using TravelAgency.Datos.Persistencia.Implementacion;
using TravelAgency.Dominio.Contratos;
using TravelAgency.Dominio.Core;
using Utilitarios.IoC;

namespace TravelAgency.Aplicacion.Implementacion
{
    public class HabitacionServicio : IHabitacionServicios
    {
        private IHabitacionRepositorio _habitacionRepositorio;

        public HabitacionServicio(IHabitacionRepositorio habitacionRepositorio)
        {
            this._habitacionRepositorio = habitacionRepositorio;
        }

        public HabitacionDTO ObtenerId(int id)
        {
            var objetoRecuperado = _habitacionRepositorio.ObtenerId(id);
            return Mapper.Map<Habitacion, HabitacionDTO>(objetoRecuperado);
        }
        public IEnumerable<HabitacionDTO> ObtenerTodos()
        {
            var lista = _habitacionRepositorio.ObtenerTodos();
            return Mapper.Map<IEnumerable<Habitacion>, IEnumerable<HabitacionDTO>>(lista);
        }

        public bool Crear(HabitacionDTO entidad)
        {
            try
            {
                var _objeto = new Habitacion();
                Mapper.Map(entidad, _objeto);
                _habitacionRepositorio.Crear(_objeto);
                _habitacionRepositorio.UnidadTrabajo.Confirmar();
                return true;
            }
            catch
            {

                return false;
            }
        }
        public bool Eliminar(HabitacionDTO entidad)
        {
            try
            {
                var _objeto = new Habitacion();
                Mapper.Map(entidad, _objeto);
                _habitacionRepositorio.Eliminar(_objeto);
                _habitacionRepositorio.UnidadTrabajo.Confirmar();
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
                if (_habitacionRepositorio != null)
                {
                    _habitacionRepositorio.Dispose();
                    _habitacionRepositorio = null;
                }
            }
        }


    }
}
