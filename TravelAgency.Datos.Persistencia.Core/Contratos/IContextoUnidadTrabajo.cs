using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Dominio.Core;

namespace TravelAgency.Datos.Persistencia.Core
{
    public interface IContextoUnidadTrabajo : IUnidadTrabajo, IDisposable
    {
        #region Tablas

        IDbSet<Agente> Agente { get; }
        IDbSet<Hoteles> Hotel { get; }
        IDbSet<AgenteHoteles> AgenteHoteles { get; }
        #endregion

        IDbSet<Entidad> Set<Entidad>() where Entidad : class;

        void Attach<Entidad>(Entidad item) where Entidad : class;
        void SetModified<Entidad>(Entidad item) where Entidad : class;
        void SetDeleted<Entidad>(Entidad item) where Entidad : class;

    }


}
