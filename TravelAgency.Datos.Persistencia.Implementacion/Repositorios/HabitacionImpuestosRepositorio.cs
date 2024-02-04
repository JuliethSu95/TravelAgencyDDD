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
    public class HabitacionImpuestosRepositorio : RepositorioBase<HabitacionImpuestos>, IHabitacionImpuestosRepositorio
    {
        public HabitacionImpuestosRepositorio(IContextoUnidadTrabajo contextoUnidadTrabajo) : base(contextoUnidadTrabajo) { }
    }
}
