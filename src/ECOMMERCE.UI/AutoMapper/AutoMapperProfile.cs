using AutoMapper;
using Domain.Entities.Estoques;
using Domain.Entities.Pessoas;
using ECOMMERCE.UI.ViewModels;

namespace ECOMMERCE.UI.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile(){
            CreateMap<PessoaTipoViewModel, PessoaTipo>();
            CreateMap<PessoaViewModel, Pessoa>();
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<ProdutoViewModel, Produto>();
        }
    }
}