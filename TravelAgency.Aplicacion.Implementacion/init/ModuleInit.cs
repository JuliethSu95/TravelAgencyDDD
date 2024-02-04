using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Datos.Persistencia.Core;
using TravelAgency.Dominio.Contratos;
using Utilitarios.IoC;
using TravelAgency.Datos.Persistencia.Implementacion;
using TravelAgency.Datos.Persistencia.Implementacion.Repositorios;

namespace TravelAgency.Aplicacion.Implementacion
{
    [Export(typeof(IModule))]
    public class ModuleInit : IModule
    {
        public void Initialize(IRegisterModules register)
        {
            register.RegisterTyper<IAgenteRepositorio, AgenteRepositorio>();
            register.RegisterTyper<IAgenteHotelesRepositorio, AgenteHotelesRepositorio>();
            register.RegisterTyper<IEstadoRepositorio, EstadoRepositorio>();
            register.RegisterTyper<IHabitacionImpuestosRepositorio, HabitacionImpuestosRepositorio>();
            register.RegisterTyper<IImpuestosRepositorio, ImpuestosRepositorio>();
            register.RegisterTyper<IHotelesRepositorio, HotelesRepositorio>();
            register.RegisterTyper<IHabitacionRepositorio, HabitacionRepositorio>();
            register.RegisterTyper<ITipoHabitacionRepositorio, TipoHabitacionRepositorio>();
            register.RegisterTyper<ITipoDocumentoRepositorio, TipoDocumentoRepositorio>();
            register.RegisterTyper<IUbicacionHabitacionRepositorio, UbicacionHabitacionRepositorio>();
        }
    }
}
