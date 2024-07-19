using Site.DTO;
using Site.IRepositorio;
using Site.IServico;
using Site.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Servico
{
    public class RotaServico : IRotaServico
    {
        IRotaRepositorio _rotaRepositorio;

        public RotaServico(IRotaRepositorio rotaRepositorio)
        {
            _rotaRepositorio = rotaRepositorio;
        }

        public IList<DTORota> GetAll()
        {
            var rotas = _rotaRepositorio.GetAll();
            return rotas;
        }

        public void Salvar(DTORota frete)
        {
            _rotaRepositorio.Salvar(frete);
        }

        public void Excluir(int id)
        {
            _rotaRepositorio.Excluir(id);
        }

        public IList<DTORotaGrid> GetRotas()
        {
            var rotas = _rotaRepositorio.GetRotas();
            return rotas;
        }
    }
}
