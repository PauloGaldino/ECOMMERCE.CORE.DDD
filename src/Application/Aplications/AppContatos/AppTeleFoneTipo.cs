using System.Collections.Generic;
using Application.Interfaces.IAppContatos;
using Domain.Entities.Contatos;
using Domain.Interfaces.Repositories.IRContatos;

namespace Application.Aplications.AppContatos
{
    public class AppTelefoneTipo : IAppTelefoneTipo
    {
        ITelefoneTipoRepository _ITelefoneTipo;
        public AppTelefoneTipo(ITelefoneTipoRepository ITelefoneTipo)
        {
            _ITelefoneTipo = ITelefoneTipo;
        }

        public void Adicionar(TelefoneTipo Objeto)
        {
            _ITelefoneTipo.Adicionar(Objeto);
        }

        public void Atualizar(TelefoneTipo Objeto)
        {
            _ITelefoneTipo.Atualizar(Objeto);
        }

        public void Excluir(TelefoneTipo Objeto)
        {
            _ITelefoneTipo.Excluir(Objeto);
        }

        public IList<TelefoneTipo> Listar()
        {
            return _ITelefoneTipo.Listar();
        }

        public TelefoneTipo ObterPorId(int Id)
        {
            return _ITelefoneTipo.ObterPorId(Id);
        }
    }
}
