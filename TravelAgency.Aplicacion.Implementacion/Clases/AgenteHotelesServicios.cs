using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Aplicacion.Contratos;
using TravelAgency.Aplicacion.Core;
using TravelAgency.Datos.Persistencia.Core;
using TravelAgency.Datos.Persistencia.Implementacion;
using TravelAgency.Dominio.Contratos;
using TravelAgency.Dominio.Core;
using Utilitarios.IoC;

namespace TravelAgency.Aplicacion.Implementacion
{
    public class AgenteHotelesServicios : IAgenteHotelesServicios
    {
        private IAgenteHotelesRepositorio _agenteHotelesRepositorio;

        public AgenteHotelesServicios(IAgenteHotelesRepositorio agenteHotelRepositorio)
        {
            this._agenteHotelesRepositorio = agenteHotelRepositorio;
        }

        public AgenteHotelesDTO ObtenerId(int id)
        {
            var objetoRecuperado = _agenteHotelesRepositorio.ObtenerId(id);
            return Mapper.Map<AgenteHoteles, AgenteHotelesDTO>(objetoRecuperado);
        }
        public IEnumerable<AgenteHotelesDTO> ObtenerTodos()
        {
            var lista = _agenteHotelesRepositorio.ObtenerTodos();
            return Mapper.Map<IEnumerable<AgenteHoteles>, IEnumerable<AgenteHotelesDTO>>(lista);
        }

        public bool Crear(AgenteHotelesDTO entidad)
        {
            try
            {
                var _objeto = new AgenteHoteles();
                Mapper.Map(entidad, _objeto);
                _agenteHotelesRepositorio.Crear(_objeto);
                _agenteHotelesRepositorio.UnidadTrabajo.Confirmar();
                return true;
            }
            catch
            {

                return false;
            }
        }
        public bool Eliminar(AgenteHotelesDTO entidad)
        {
            try
            {
                var _objeto = new AgenteHoteles();
                Mapper.Map(entidad, _objeto);
                _agenteHotelesRepositorio.Eliminar(_objeto);
                _agenteHotelesRepositorio.UnidadTrabajo.Confirmar();
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
                if (_agenteHotelesRepositorio != null)
                {
                    _agenteHotelesRepositorio.Dispose();
                    _agenteHotelesRepositorio = null;
                }
            }
        }

       
    }
}
