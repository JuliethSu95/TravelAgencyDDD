using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios.IoC
{
    public interface IRegisterModules
    {
        void RegisterTyper<TFrom, TTo>(bool withIterception = false) where TTo : TFrom;
        void RegisterTyperWithLifeTime<TFrom, TTo>(bool withIterception = false) where TTo : TFrom;
    }
}
