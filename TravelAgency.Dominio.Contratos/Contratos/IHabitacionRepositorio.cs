﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Dominio.Core;

namespace TravelAgency.Dominio.Contratos
{
    public interface IHabitacionRepositorio : IRepositorioBase<Habitacion>, IDisposable
    {
    }
}
