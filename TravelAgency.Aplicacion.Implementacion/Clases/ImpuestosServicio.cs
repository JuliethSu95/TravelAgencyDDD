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
using TravelAgency.Datos.Persistencia.Implementacion.Repositorios;
using TravelAgency.Dominio.Contratos;
using TravelAgency.Dominio.Core;
using Utilitarios.IoC;

namespace TravelAgency.Aplicacion.Implementacion
{
    public class ImpuestosServicio : IImpuestosServicios
    {
        private IImpuestosRepositorio _impuestosRepositorio;

        public ImpuestosServicio(IImpuestosRepositorio impuestosRepositorio)
        {
            this._impuestosRepositorio = impuestosRepositorio;
        }

        public ImpuestosDTO ObtenerId(int id)
        {
            var objetoRecuperado = _impuestosRepositorio.ObtenerId(id);
            return Mapper.Map<Impuestos, ImpuestosDTO>(objetoRecuperado);
        }
        public IEnumerable<ImpuestosDTO> ObtenerTodos()
        {
            var lista = _impuestosRepositorio.ObtenerTodos();
            return Mapper.Map<IEnumerable<Impuestos>, IEnumerable<ImpuestosDTO>>(lista);
        }

        public bool Crear(ImpuestosDTO entidad)
        {
            try
            {
                var _objeto = new Impuestos();
                Mapper.Map(entidad, _objeto);
                _impuestosRepositorio.Crear(_objeto);
                _impuestosRepositorio.UnidadTrabajo.Confirmar();
                return true;
            }
            catch
            {

                return false;
            }
        }
        public bool Eliminar(ImpuestosDTO entidad)
        {
            try
            {
                var _objeto = new Impuestos();
                Mapper.Map(entidad, _objeto);
                _impuestosRepositorio.Eliminar(_objeto);
                _impuestosRepositorio.UnidadTrabajo.Confirmar();
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
                if (_impuestosRepositorio != null)
                {
                    _impuestosRepositorio.Dispose();
                    _impuestosRepositorio = null;
                }
            }
        }


    }
}
