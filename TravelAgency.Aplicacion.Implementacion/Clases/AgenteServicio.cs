using AutoMapper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Aplicacion.Contratos;
using TravelAgency.Aplicacion.Core;
using TravelAgency.Dominio.Contratos;
using TravelAgency.Dominio.Core;

namespace TravelAgency.Aplicacion.Implementacion
{
    public class AgenteServicio : IAgenteServicios
    {
        private IAgenteRepositorio _agenteRepositorio;

        public AgenteServicio(IAgenteRepositorio agenteRepositorio)
        {
            this._agenteRepositorio = agenteRepositorio;
        }

        public AgenteDTO ObtenerId(int id)
        {
            var objetoRecuperado = _agenteRepositorio.ObtenerId(id);
            return Mapper.Map<Agente, AgenteDTO>(objetoRecuperado);
        }
        public IEnumerable<AgenteDTO> ObtenerTodos()
        {
            var lista = _agenteRepositorio.ObtenerTodos();
            return Mapper.Map<IEnumerable<Agente>, IEnumerable<AgenteDTO>>(lista);
        }

        public bool Crear(AgenteDTO entidad)
        {
            try
            {
                var _objeto = new Agente();
                Mapper.Map(entidad, _objeto);
                _agenteRepositorio.Crear(_objeto);
                _agenteRepositorio.UnidadTrabajo.Confirmar();
                return true;
            }
            catch
            {

                return false;
            }
        }
        public bool Eliminar(AgenteDTO entidad)
        {
            try
            {
                var _objeto = new Agente();
                Mapper.Map(entidad, _objeto);
                _agenteRepositorio.Eliminar(_objeto);
                _agenteRepositorio.UnidadTrabajo.Confirmar();
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
                if (_agenteRepositorio != null)
                {
                    _agenteRepositorio.Dispose();
                    _agenteRepositorio = null;
                }
            }
        }
    }
}
