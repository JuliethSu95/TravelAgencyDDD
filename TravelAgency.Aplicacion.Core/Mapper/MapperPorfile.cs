using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Dominio.Core;

namespace TravelAgency.Aplicacion.Core
{
    public class MapperPorfile : Profile
    {
        public MapperPorfile() 
        {
            CreateMap<Agente, AgenteDTO>();
            CreateMap<AgenteDTO, Agente>();

            CreateMap<Hoteles, HotelesDTO>();
            CreateMap<HotelesDTO, Hoteles>();

            CreateMap<AgenteHoteles, AgenteHotelesDTO>();
            CreateMap<AgenteHotelesDTO, AgenteHoteles>();

            CreateMap<Estado, EstadoDTO>();
            CreateMap<EstadoDTO, Estado>();

            CreateMap<Habitacion, HabitacionDTO>();
            CreateMap<HabitacionDTO, Habitacion>();

            CreateMap<HabitacionImpuestos, HabitacionImpuestosDTO>();
            CreateMap<HabitacionImpuestosDTO, HabitacionImpuestos>();

            CreateMap<Impuestos, ImpuestosDTO>();
            CreateMap<ImpuestosDTO, Impuestos>();

            CreateMap<TipoDocumento, TipoDocumentoDTO>();
            CreateMap<TipoDocumentoDTO, TipoDocumento>();

            CreateMap<TipoHabitacion, TipoHabitacionDTO>();
            CreateMap<TipoHabitacionDTO, TipoHabitacion>();

            CreateMap<UbicacionHabitacion, UbicacionHabitacionDTO>();
            CreateMap<UbicacionHabitacionDTO, UbicacionHabitacion>();


        }
    }
}
