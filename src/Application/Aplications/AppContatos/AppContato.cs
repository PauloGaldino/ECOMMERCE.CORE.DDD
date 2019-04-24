using System.Collections.Generic;
using Application.Interfaces.IAppContatos;
using Domain.Entities.Contatos;
using Domain.Interfaces.Repositories.IRContatos;

namespace Application.Aplications.AppContatos
{
    public class AppContato : IAppContatoService
    {
        IContatoRepository _IContato;
            public AppContato(IContatoRepository IContato)
        {
            _IContato = IContato;
        }

        public void Adicionar(Contato Objeto)
        {
            _IContato.Adicionar(Objeto);
        }

        public void Atualizar(Contato Objeto)
        {
            _IContato.Atualizar(Objeto);
        }

        public void Excluir(Contato Objeto)
        {
            _IContato.Excluir(Objeto);
        }

        public IList<Contato> Listar()
        {
           return _IContato.Listar();
        }

        public Contato ObterPorId(int Id)
        {
           return  _IContato.ObterPorId(Id);
        }
    }
}
