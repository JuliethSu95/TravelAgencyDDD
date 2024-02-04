using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Unity;
using Utilitarios.IoC;

namespace TravelAgency.Service.App_Start
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();
            ModuleLoader.LoadContainer(container, ".\\bin", "*.Inicializador.dll");
            //ModuleLoader
            //GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }
    }
}