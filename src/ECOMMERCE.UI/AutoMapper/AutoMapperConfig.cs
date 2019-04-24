using AutoMapper;

namespace ECOMMERCE.UI.AutoMapper
{

    public class AutoMapperConfig 
    {
        public static void RegistreMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToViewModelMappingProfile>();
                x.AddProfile<ViewModelToDomainMappingProfile>();
            });

        }
    }
}