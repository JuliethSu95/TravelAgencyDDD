using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Datos.Persistencia.Core;
using TravelAgency.Dominio.Contratos;
using Utilitarios.IoC;

namespace TravelAgency.Datos.Persistencia.Implementacion
{
    [Export(typeof(IModule))]
    public class ModuleInit:IModule
    {
        public void Initialize(IRegisterModules register)
        {
            register.RegisterTyper<IContextoUnidadTrabajo, ContextoPrincipal>();
            register.RegisterTyper<IAgenteRepositorio, AgenteRepositorio>();

            register.RegisterTyper<IContextoUnidadTrabajo, ContextoPrincipal>();
            register.RegisterTyper<IHotelesRepositorio, HotelesRepositorio>();

            register.RegisterTyper<IContextoUnidadTrabajo, ContextoPrincipal>();
            register.RegisterTyper<IAgenteHotelesRepositorio, AgenteHotelesRepositorio>();

        
        }
    }
}
