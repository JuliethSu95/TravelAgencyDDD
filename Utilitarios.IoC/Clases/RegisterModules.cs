using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Lifetime;

namespace Utilitarios.IoC
{
    public class RegisterModules : IRegisterModules
    {
        private readonly IUnityContainer _container;

        public RegisterModules(IUnityContainer container)
        {
            _container = container;
        }
        public void RegisterTyper<TFrom, TTo>(bool withIterception = false) where TTo : TFrom
        {
            if (withIterception) { _container.RegisterType<TFrom, TTo>(); }
        }

        public void RegisterTyperWithLifeTime<TFrom, TTo>(bool withIterception = false) where TTo : TFrom
        {
            _container.RegisterType<TFrom, TTo>(new ContainerControlledLifetimeManager());
        }
    }
}
