using Microsoft.VisualStudio.TestTools.UnitTesting;
using Site.IServico;
using Site.Repositorio;
using Site.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Testes
{
    [TestClass]
    public class FreteServicoTest
    {
        private readonly IFreteServico _freteServico = new FreteServico(new FreteRepositorio());

        [TestMethod]
        public void ListarFretesServico()
        {
            var fretes = _freteServico.GetAll();




        }
    }
}
