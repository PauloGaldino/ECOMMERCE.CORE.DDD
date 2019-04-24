using Domain.Entities.Pessoas;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Domain.Interfaces.IPessoas
{
    public interface IPessoaTipoRepository : IRepositoryBase<PessoaTipo>
    {
        //IEnumerable<PessoaTipo> BuscarPorNome(string nome);
    }
}
