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
    public class EstadoServicio : IEstadoServicios
    {
        private IEstadoRepositorio _estadoRepositorio;

        public EstadoServicio(IEstadoRepositorio estadoRepositorio)
        {
            this._estadoRepositorio = estadoRepositorio;
        }

        public EstadoDTO ObtenerId(int id)
        {
            var objetoRecuperado = _estadoRepositorio.ObtenerId(id);
            return Mapper.Map<Estado, EstadoDTO>(objetoRecuperado);
        }
        public IEnumerable<EstadoDTO> ObtenerTodos()
        {
            var lista = _estadoRepositorio.ObtenerTodos();
            return Mapper.Map<IEnumerable<Estado>, IEnumerable<EstadoDTO>>(lista);
        }

        public bool Crear(EstadoDTO entidad)
        {
            try
            {
                var _objeto = new Estado();
                Mapper.Map(entidad, _objeto);
                _estadoRepositorio.Crear(_objeto);
                _estadoRepositorio.UnidadTrabajo.Confirmar();
                return true;
            }
            catch
            {

                return false;
            }
        }
        public bool Eliminar(EstadoDTO entidad)
        {
            try
            {
                var _objeto = new Estado();
                Mapper.Map(entidad, _objeto);
                _estadoRepositorio.Eliminar(_objeto);
                _estadoRepositorio.UnidadTrabajo.Confirmar();
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
                if (_estadoRepositorio != null)
                {
                    _estadoRepositorio.Dispose();
                    _estadoRepositorio = null;
                }
            }
        }


    }


}

