using St.Controllers;
using St.Providers;
using System.Web.Mvc;
using Unity;
using Unity.Injection;
using Unity.Mvc5;

namespace St
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<AccountController>(new InjectionConstructor());
            container.RegisterType<ManageController>(new InjectionConstructor());
            container.RegisterType<ISiteConfigManager, SiteConfigManager>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}