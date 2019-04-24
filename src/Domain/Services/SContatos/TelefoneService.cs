using Domain.Entities.Contatos;
using Domain.Interfaces.Repositories.IRContatos;
using Domain.Interfaces.Services.ISContatos;

namespace Domain.Services.SContatos
{
    public class TelefoneService : ServiceBase<Telefone>, ITelefoneService
    {
        private readonly ITelefoneRepository _telefoneRepository;
        public TelefoneService(ITelefoneRepository telefoneRepository) :base(telefoneRepository)
        {
            _telefoneRepository = telefoneRepository;
        }
    }
}
