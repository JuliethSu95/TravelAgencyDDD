﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Aplicacion.Core;

namespace Utilitarios.IoC
{
    public sealed class MapperInitializer
    {
        public static void ConfigurarMapeos()
        {
            Mapper.Initialize(map => { map.AddProfile<MapperPorfile>(); });
        }
    }
}
