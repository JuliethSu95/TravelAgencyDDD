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
    public class HabitacionImpuestosServicio : IHabitacionImpuestosServicios
    {
        private IHabitacionImpuestosRepositorio _habitacionImpuestosRepositorio;

        public HabitacionImpuestosServicio(IHabitacionImpuestosRepositorio habitacionImpuestosRepositorio)
        {
            this._habitacionImpuestosRepositorio = habitacionImpuestosRepositorio;
        }

        public HabitacionImpuestosDTO ObtenerId(int id)
        {
            var objetoRecuperado = _habitacionImpuestosRepositorio.ObtenerId(id);
            return Mapper.Map<HabitacionImpuestos, HabitacionImpuestosDTO>(objetoRecuperado);
        }
        public IEnumerable<HabitacionImpuestosDTO> ObtenerTodos()
        {
            var lista = _habitacionImpuestosRepositorio.ObtenerTodos();
            return Mapper.Map<IEnumerable<HabitacionImpuestos>, IEnumerable<HabitacionImpuestosDTO>>(lista);
        }

        public bool Crear(HabitacionImpuestosDTO entidad)
        {
            try
            {
                var _objeto = new HabitacionImpuestos();
                Mapper.Map(entidad, _objeto);
                _habitacionImpuestosRepositorio.Crear(_objeto);
                _habitacionImpuestosRepositorio.UnidadTrabajo.Confirmar();
                return true;
            }
            catch
            {

                return false;
            }
        }
        public bool Eliminar(HabitacionImpuestosDTO entidad)
        {
            try
            {
                var _objeto = new HabitacionImpuestos();
                Mapper.Map(entidad, _objeto);
                _habitacionImpuestosRepositorio.Eliminar(_objeto);
                _habitacionImpuestosRepositorio.UnidadTrabajo.Confirmar();
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
                if (_habitacionImpuestosRepositorio != null)
                {
                    _habitacionImpuestosRepositorio.Dispose();
                    _habitacionImpuestosRepositorio = null;
                }
            }
        }


    }
   
}
