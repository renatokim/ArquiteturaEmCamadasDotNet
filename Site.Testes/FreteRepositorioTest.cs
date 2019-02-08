using Microsoft.VisualStudio.TestTools.UnitTesting;
using Site.IRepositorio;
using Site.IRepositorio.Chamados;
using Site.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Testes
{
    [TestClass]
    public class FreteRepositorioTest
    {
        private readonly IFreteRepositorio _freteRepositorio = new FreteRepositorio();

        [TestMethod]
        public void ListarFretesRepositorio()
        {
            var fretes = _freteRepositorio.GetAll();




        }
    }
}
