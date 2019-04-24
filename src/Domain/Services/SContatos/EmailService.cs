using Domain.Entities.Contatos;
using Domain.Interfaces.Repositories.IRContatos;
using Domain.Interfaces.Services.ISContatos;

namespace Domain.Services.SContatos
{
    public class EmailService : ServiceBase<Email>, IEmailService
    {
        private readonly IEmailRepository _emailRepository;
        public EmailService(IEmailRepository emailRepository): base(emailRepository)
        {
            _emailRepository = emailRepository;
        }
    }
}
