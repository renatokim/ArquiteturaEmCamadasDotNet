using SimpleInjector;
using Site.IRepositorio;
using Site.IServico;
using Site.Repositorio;
using Site.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInjectorConsole
{
    class Program
    {
        static Container container;

        static void Main(string[] args)
        {
            Start();

            //IFreteServico _freteServico = ServiceFactory.CreateInstance<IFreteServico>();
            //var fretes = _freteServico.GetAll();

            var handler = container.GetInstance<FreteServico>();
            var fretesInj = handler.GetAll();

        }

        static void Start()
        {
            container = new Container();
            container.Register<IFreteServico, FreteServico>(Lifestyle.Singleton);
            container.Register<IFreteRepositorio, FreteRepositorio>(Lifestyle.Singleton);
            
            container.Verify();
        }
    }
}
