using Domain.Entities.Contatos;
using Domain.Interfaces.Repositories.IRContatos;
using Domain.Interfaces.Services.ISContatos;

namespace Domain.Services.SContatos
{
   public class ContatoService : ServiceBase<Contato>, IContatoService
    {
        private readonly IContatoRepository _contatoRepository;
        public ContatoService(IContatoRepository contatoRepository): base(contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }
    }
}
