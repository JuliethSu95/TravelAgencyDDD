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
    public class UbicacionHabitacionServicio : IUbicacionHabitacionServicios
    {
        private IUbicacionHabitacionRepositorio _ubicacionHabitacion;

        public UbicacionHabitacionServicio(IUbicacionHabitacionRepositorio ubicacionHabitacion)
        {
            this._ubicacionHabitacion = ubicacionHabitacion;
        }

        public UbicacionHabitacionDTO ObtenerId(int id)
        {
            var objetoRecuperado = _ubicacionHabitacion.ObtenerId(id);
            return Mapper.Map<UbicacionHabitacion, UbicacionHabitacionDTO>(objetoRecuperado);
        }
        public IEnumerable<UbicacionHabitacionDTO> ObtenerTodos()
        {
            var lista = _ubicacionHabitacion.ObtenerTodos();
            return Mapper.Map<IEnumerable<UbicacionHabitacion>, IEnumerable<UbicacionHabitacionDTO>>(lista);
        }

        public bool Crear(UbicacionHabitacionDTO entidad)
        {
            try
            {
                var _objeto = new UbicacionHabitacion();
                Mapper.Map(entidad, _objeto);
                _ubicacionHabitacion.Crear(_objeto);
                _ubicacionHabitacion.UnidadTrabajo.Confirmar();
                return true;
            }
            catch
            {

                return false;
            }
        }
        public bool Eliminar(UbicacionHabitacionDTO entidad)
        {
            try
            {
                var _objeto = new UbicacionHabitacion();
                Mapper.Map(entidad, _objeto);
                _ubicacionHabitacion.Eliminar(_objeto);
                _ubicacionHabitacion.UnidadTrabajo.Confirmar();
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
                if (_ubicacionHabitacion != null)
                {
                    _ubicacionHabitacion.Dispose();
                    _ubicacionHabitacion = null;
                }
            }
        }


    }
}
