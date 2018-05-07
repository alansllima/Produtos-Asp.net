[assembly: WebActivator.PostApplicationStartMethod(typeof(ProjetoModeloDDD.MVC.App_Start.SimpleInjectorInitializer), "Initialize")]

namespace ProjetoModeloDDD.MVC.App_Start
{
    using System.Reflection;
    using System.Web.Mvc;
    using ProjetoModeloDDD.Application;
    using ProjetoModeloDDD.Application.Interface;
    using ProjetoModeloDDD.Domain.Interfaces.Repositories;
    using ProjetoModeloDDD.Domain.Services;
    using ProjetoModeloDDD.Infra.Data.Repositories;
    using SimpleInjector;
    using SimpleInjector.Integration.Web;
    using SimpleInjector.Integration.Web.Mvc;
    
    public static class SimpleInjectorInitializer
    {
        /// <summary>Initialize the container and register it as MVC3 Dependency Resolver.</summary>
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
            
            InitializeContainer(container);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            
            container.Verify();
            
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
     
        private static void InitializeContainer(Container container)
        {
            //Register your services here (remove this line).

            // For instance:
            // container.Register<IUserRepository, SqlUserRepository>(Lifestyle.Scoped);


            container.Register(typeof(IServiceBase<>), typeof(ServiceBase<>), Lifestyle.Scoped);

            container.Register<IClienteService, ClienteService>(Lifestyle.Scoped);
            container.Register<IProdutoService, ProdutoService>(Lifestyle.Scoped);

            container.Register(typeof(IRepositoryBase<>), typeof(RepositoryBase<>), Lifestyle.Scoped);
            container.Register(typeof(IAppServiceBase<>), typeof(AppServiceBase<>), Lifestyle.Scoped);
            container.Register<IClienteRepository, ClienteRepository>(Lifestyle.Scoped);
            container.Register<IProdutoRepository, ProdutoRepository>(Lifestyle.Scoped);

            
            container.Register<IClienteAppService, ClienteAppService>(Lifestyle.Scoped);
            container.Register<IProdutoAppService, ProdutoAppService>(Lifestyle.Scoped);
            






        }
    }
}