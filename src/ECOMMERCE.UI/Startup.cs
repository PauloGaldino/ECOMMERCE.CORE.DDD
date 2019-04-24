using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ECOMMERCE.UI.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Infra.Data.Data.Context;
using AutoMapper;
using ECOMMERCE.UI.AutoMapper;
using Domain.Interfaces.Services;
using Domain.Services;
using Application.Interfaces;
using Application.Interfaces.IAppPessoas;
using Application.Aplications.AppPessoas;
using Application.Interfaces.IAppPessoas.IAppProfissoes;
using Application.Aplications.AppPessoas.AppProfissoes;
using Application.Interfaces.IAppContatos;
using Application.Aplications.AppContatos;
using Application.Interfaces.IAppVendas;
using Application.Aplications.AppVendas;
using Domain.Interfaces.IPessoas;
using Infra.Data.Repositories.RPessoas;
using Domain.Interfaces.Repositories.IRPessoas;
using Domain.Interfaces.Services.ISPessoas;
using Domain.Services.SPessoas;
using Microsoft.AspNetCore.Mvc.Controllers;
using SimpleInjector.Lifestyles;
using SimpleInjector;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Application.Aplications;
using Domain.Interfaces.Repositories;
using Infra.Data.Repositories;
using Domain.Interfaces.IVendas;
using Infra.Data.Repositories.RVendas;
using SimpleInjector.Integration.AspNetCore.Mvc;
using Domain.Interfaces.Services.ISPessoas.ISProfissoes;
using Domain.Services.SPessoas.SProfissoes;
using Domain.Interfaces.Services.ISContatos;
using Domain.Services.SContatos;
using Domain.Interfaces.Services.ISVendas;
using Domain.Services.SVendas;
using Domain.Services.SEstoques;
using Domain.Interfaces.Services.ISEstoque;
using Domain.Interfaces.Repositories.IRContatos;
using Infra.Data.Repositories.RContatos;
using Domain.Interfaces.Repositories.IRVendas;
using APPLICATION.interfaces.IAppVendas;
using APPLICATION.Application;

namespace ECOMMERCE.UI
{
    public class Startup
    {
        private Container container = new Container();
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddDbContext<DbContextGeral>(options =>
              options.UseSqlServer(
                  Configuration.GetConnectionString("DefaultConnection")));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
           
            Mapper.Initialize(cfg => cfg.AddProfile<AutoMapperProfile>());

            IntegrateSimpleInjector(services);

            services.AddAutoMapper();
            services.AddMvc();  
        }

        /// <summary>
        /// https://simpleinjector.readthedocs.io/en/latest/aspnetintegration.html
        /// https://github.com/simpleinjector/SimpleInjector/blob/master/src/SimpleInjector.Integration.AspNetCore.Mvc.Core/SimpleInjectorControllerActivator.cs
        /// </summary>
        /// <param name="services"></param>
        private void IntegrateSimpleInjector(IServiceCollection services)
        {
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddSingleton<IControllerActivator>(new SimpleInjectorControllerActivator(container));

            services.AddSingleton<IViewComponentActivator>(new SimpleInjectorViewComponentActivator(container));

            services.EnableSimpleInjectorCrossWiring(container);
            services.UseSimpleInjectorAspNetRequestScoping(container);

        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            InitializeContainer(app);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=PessoaTipoViewModel}/{action=Index}/{id?}");
            });
        }

        private void InitializeContainer(IApplicationBuilder app)
        {
            //add application presentation components
            container.RegisterMvcControllers(app);
            container.RegisterMvcViewComponents(app);


            // add application services.For instance
            //App
            container.Register(typeof(IAppServiceBase<>), typeof(AppServiceBase<>).Assembly, Lifestyle.Scoped);
            container.Register<IAppPessoaTipo, AppPessoaTipo>(Lifestyle.Scoped); 
            container.Register<IAppPessoaService, AppPessoa>(Lifestyle.Scoped); 
            container.Register<IAppJuridicaService, AppJuridica>(Lifestyle.Scoped); 
            container.Register<IAppFisicaService, AppFisica>(Lifestyle.Scoped);
            container.Register<IAppClienteService, AppCliente>(Lifestyle.Scoped);

            container.Register<IAppProfissaoService, AppProfissao>(Lifestyle.Scoped);
            container.Register<IAppProfissaoClienteService, AppProfissaoCliente>(Lifestyle.Scoped);
            container.Register<IAppProfissaoPessoaService, AppProfissaoPessoa>(Lifestyle.Scoped);

            container.Register<IAppContatoService, AppContato>(Lifestyle.Scoped);
            container.Register<IAppEmailService, AppEmail>(Lifestyle.Scoped);
            container.Register<IAppEnderecoSerice, AppEndereco>(Lifestyle.Scoped);
            container.Register<IAppEnderecoCliente, AppEnderecoCliente>(Lifestyle.Scoped);
            container.Register<IAppEnderecoPessoa, AppEnderecoPessoa>(Lifestyle.Scoped);
            container.Register<IAppTelefone, AppTelefone>(Lifestyle.Scoped);
            container.Register<IAppTelefoneTipo, AppTelefoneTipo>(Lifestyle.Scoped);

            container.Register<IAppBebida, AppBebida>(Lifestyle.Scoped);
            container.Register<IAppProdutoService, AppProduto>(Lifestyle.Scoped);


            //Domain
            container.Register(typeof(IServiceBase<>), typeof(ServiceBase<>).Assembly, Lifestyle.Scoped);
            container.Register<IPessoaTipoService, PessoaTipoService>(Lifestyle.Scoped);
            container.Register<IPessoaService, PessoaService>(Lifestyle.Scoped);
            container.Register<IFisicaService, FisicaService>(Lifestyle.Scoped);
            container.Register<IJuridicaService, JuridicaService>(Lifestyle.Scoped);
            container.Register<IClienteService, ClienteService>(Lifestyle.Scoped);

            container.Register<IProfissaoService, ProfissaoService>(Lifestyle.Scoped);
            container.Register<IProfissaoClienteService, ProfissaoClienteService>(Lifestyle.Scoped);
            container.Register<IProfissaoPessoaService, ProfissaoPessoaService>(Lifestyle.Scoped);

            container.Register<IContatoService, ContatoService>(Lifestyle.Scoped);
            container.Register<IEmailService, EmailService>(Lifestyle.Scoped);
            container.Register<IEnderecoService, EnderecoService>(Lifestyle.Scoped);
            container.Register<IEnderecoClienteService, EnderecoClienteService>(Lifestyle.Scoped);
            container.Register<IEnderecoPessoaService, EnderecoPessoaService>(Lifestyle.Scoped);
            container.Register<TelefoneTipoService, TelefoneTipoService>(Lifestyle.Scoped);
            container.Register<TelefoneService, TelefoneService>(Lifestyle.Scoped);

            container.Register<IBebidaService, BebidaService>(Lifestyle.Scoped);
            container.Register<IProdutoService, ProdutoService>(Lifestyle.Scoped);

            container.Register<IEstoqueService, EstoqueService>(Lifestyle.Scoped);

            //Infra
            container.Register(typeof(IRepositoryBase<>), typeof(RepositoryBase<>).Assembly, Lifestyle.Scoped);
            container.Register<IPessoaTipoRepository, PessoaTipoRepository>(Lifestyle.Scoped);
            container.Register<IPessoaRepository, PessoaRepository>(Lifestyle.Scoped);
            container.Register<IFisicaRepository, FisicaRepository>(Lifestyle.Scoped);
            container.Register<IJuridicaRepository, JuridicaRepository>(Lifestyle.Scoped);
            container.Register<IClienteRepository, ClienteRepository>(Lifestyle.Scoped);

            container.Register<IContatoRepository, ContatoRepository>(Lifestyle.Scoped);
            container.Register<IEmailRepository, EmailRepository>(Lifestyle.Scoped);
            container.Register<IEnderecoRepository, EnderecoRepository>(Lifestyle.Scoped);
            container.Register<IEnderecoClienteRepository, EnderecoClienteRepository>(Lifestyle.Scoped);
            container.Register<IEnderecoPessoaRepository, EnderecoPessoaRepository>(Lifestyle.Scoped);
            container.Register<ITelefoneTipoRepository, TelefoneTipoRepository>(Lifestyle.Scoped);
            container.Register<ITelefoneRepository, TelefoneRepository>(Lifestyle.Scoped);

            container.Register<IBebidaRepository, BebidaRepository>(Lifestyle.Scoped);
            container.Register<IProdutoRepository, ProdutotRepository>(Lifestyle.Scoped);
          

       
            //allow Simple Injector to resolve services from ASP.NET Core
            container.AutoCrossWireAspNetComponents(app);
        }
    }
}
