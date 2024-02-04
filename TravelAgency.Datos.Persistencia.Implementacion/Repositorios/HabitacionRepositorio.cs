using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Datos.Persistencia.Core;
using TravelAgency.Datos.Persistencia.Repositorios;
using TravelAgency.Dominio.Contratos;
using TravelAgency.Dominio.Core;

namespace TravelAgency.Datos.Persistencia.Implementacion
{
    public class HabitacionRepositorio : RepositorioBase<Habitacion>, IHabitacionRepositorio
    {
        public HabitacionRepositorio(IContextoUnidadTrabajo contextoUnidadTrabajo) : base(contextoUnidadTrabajo) { }
    }
}
