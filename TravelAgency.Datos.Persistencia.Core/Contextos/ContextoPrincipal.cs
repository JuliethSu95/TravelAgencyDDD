using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using TravelAgency.Dominio.Core;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TravelAgency.Datos.Persistencia.Core
{
    public class ContextoPrincipal : DbContext, IContextoUnidadTrabajo
    {
        public ContextoPrincipal() :base ("DefaultConnection") { }

        IDbSet<Agente> _agente;
        IDbSet<Hoteles> _hotel;
        IDbSet<AgenteHoteles> _agenteHotel;

        public IDbSet<Agente> Agente
        {
            get { return _agente ?? (_agente = base.Set<Agente>()); }
        }

        public IDbSet<Hoteles> Hotel
        {
            get { return _hotel ?? (_hotel = base.Set<Hoteles>()); }
        }

        public IDbSet<AgenteHoteles> AgenteHoteles
        {
            get { return _agenteHotel ?? (_agenteHotel = base.Set<AgenteHoteles>()); }
        }

        public new IDbSet<Entidad> Set<Entidad>() where Entidad : class
        {
            return base.Set<Entidad>();
        }

        public void Attach<Entidad>(Entidad item) where Entidad : class
        {
            if (Entry(item).State == EntityState.Detached)
            {
                base.Set<Entidad>().Attach(item);
            }
        }
        public void SetModified<Entidad>(Entidad item) where Entidad : class
        {
            Entry(item).State = EntityState.Modified;
        }
        public void SetDeleted<Entidad>(Entidad item) where Entidad : class
        {
            Entry(item).State = EntityState.Deleted;
        }

        public void Confirmar()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Configuration.LazyLoadingEnabled = false;
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }

      

        //public System.Data.Entity.DbSet<TravelAgency.Aplicacion.Core.AgenteDTO> AgenteDTO { get; set; }
    }
}
