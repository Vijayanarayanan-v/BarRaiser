using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using UnityWebApiDependencyResolver = Unity.WebApi.UnityDependencyResolver;
using Unity.WebApi;
using System.Web.Http;
using WebApplication1.Logic;

namespace WebApplication1
{
    public static class UnityConfig
    {
        

        public static void RegisterComponents()
        {


            var container = new UnityContainer();
            container.RegisterSingleton<IQuizLogic, Quizlogic>();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityWebApiDependencyResolver(container);
           // DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));
        }


        
      
    }
}