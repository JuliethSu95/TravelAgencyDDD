using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Dominio.Core
{
    public interface IUnidadTrabajo:IDisposable
    {
        void Confirmar(); //Commit
    }
}
