using AutoMapper;
using ConsolePrj.MyAutoMapper.Profiles;

namespace ConsolePrj.MyAutoMapper
{
    public class MyAutoMapperFactory
    {
        private IMapper mapper;

        public IMapper GetMapper()
        {
            if (this.mapper is null)
            {
                MapperConfiguration mapperConfiguration = GetMapperConfiguration();


                this.mapper = mapperConfiguration.CreateMapper();
            }
            return this.mapper;
        }

        public MapperConfiguration GetMapperConfiguration()
        {
            var retour = new MapperConfiguration(
                (IMapperConfigurationExpression poConfig) =>
                {
                    poConfig.AddProfile<PersonneProfile>();
                    poConfig.AddProfile<CouponProfile>();
                }
            );
            return retour;
        }
    }
}
