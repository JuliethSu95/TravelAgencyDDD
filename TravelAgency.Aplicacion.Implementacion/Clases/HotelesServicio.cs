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
    public class HotelesServicio : IHotelesServicios
    {
        private IHotelesRepositorio _hotelesRepositorio;

        public HotelesServicio(IHotelesRepositorio hotelesRepositorio)
        {
            this._hotelesRepositorio = hotelesRepositorio;
        }

        public HotelesDTO ObtenerId(int id)
        {
            var objetoRecuperado = _hotelesRepositorio.ObtenerId(id);
            return Mapper.Map<Hoteles, HotelesDTO>(objetoRecuperado);
        }
        public IEnumerable<HotelesDTO> ObtenerTodos()
        {
            var lista = _hotelesRepositorio.ObtenerTodos();
            return Mapper.Map<IEnumerable<Hoteles>, IEnumerable<HotelesDTO>>(lista);
        }

        public bool Crear(HotelesDTO entidad)
        {
            try
            {
                var _objeto = new Hoteles();
                Mapper.Map(entidad, _objeto);
                _hotelesRepositorio.Crear(_objeto);
                _hotelesRepositorio.UnidadTrabajo.Confirmar();
                return true;
            }
            catch
            {

                return false;
            }
        }
        public bool Eliminar(HotelesDTO entidad)
        {
            try
            {
                var _objeto = new Hoteles();
                Mapper.Map(entidad, _objeto);
                _hotelesRepositorio.Eliminar(_objeto);
                _hotelesRepositorio.UnidadTrabajo.Confirmar();
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
                if (_hotelesRepositorio != null)
                {
                    _hotelesRepositorio.Dispose();
                    _hotelesRepositorio = null;
                }
            }
        }


    }
}
