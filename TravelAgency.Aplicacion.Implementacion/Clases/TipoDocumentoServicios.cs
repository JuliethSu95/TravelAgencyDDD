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
    public class TipoDocumentoServicios : ITipoDocumentoServicios
    {
        private ITipoDocumentoRepositorio _tipoDocumentoRepositorio;

        public TipoDocumentoServicios(ITipoDocumentoRepositorio tipoDocumentoRepositorio)
        {
            this._tipoDocumentoRepositorio = tipoDocumentoRepositorio;
        }

        public TipoDocumentoDTO ObtenerId(int id)
        {
            var objetoRecuperado = _tipoDocumentoRepositorio.ObtenerId(id);
            return Mapper.Map<TipoDocumento, TipoDocumentoDTO>(objetoRecuperado);
        }
        public IEnumerable<TipoDocumentoDTO> ObtenerTodos()
        {
            var lista = _tipoDocumentoRepositorio.ObtenerTodos();
            return Mapper.Map<IEnumerable<TipoDocumento>, IEnumerable<TipoDocumentoDTO>>(lista);
        }

        public bool Crear(TipoDocumentoDTO entidad)
        {
            try
            {
                var _objeto = new TipoDocumento();
                Mapper.Map(entidad, _objeto);
                _tipoDocumentoRepositorio.Crear(_objeto);
                _tipoDocumentoRepositorio.UnidadTrabajo.Confirmar();
                return true;
            }
            catch
            {

                return false;
            }
        }
        public bool Eliminar(TipoDocumentoDTO entidad)
        {
            try
            {
                var _objeto = new TipoDocumento();
                Mapper.Map(entidad, _objeto);
                _tipoDocumentoRepositorio.Eliminar(_objeto);
                _tipoDocumentoRepositorio.UnidadTrabajo.Confirmar();
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
                if (_tipoDocumentoRepositorio != null)
                {
                    _tipoDocumentoRepositorio.Dispose();
                    _tipoDocumentoRepositorio = null;
                }
            }
        }


    }
}
