using Domain.Entities.Contatos;
using Domain.Interfaces.Repositories.IRContatos;
using Domain.Interfaces.Services.ISContatos;

namespace Domain.Services.SContatos
{
    public class TelefoneTipoService :ServiceBase<TelefoneTipo>, ITelefoneTipoService
    {
        private readonly ITelefoneTipoRepository _telefoneTipoRepository;
        public TelefoneTipoService(ITelefoneTipoRepository telefoneTipoRepository) : base(telefoneTipoRepository)
        {
            _telefoneTipoRepository = telefoneTipoRepository;
        }
    }
}
