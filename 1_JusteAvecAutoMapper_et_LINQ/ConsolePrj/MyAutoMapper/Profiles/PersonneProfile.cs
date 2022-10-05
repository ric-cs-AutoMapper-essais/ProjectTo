using AutoMapper;
using ConsolePrj.DTOs;
using ConsolePrj.Entities;

namespace ConsolePrj.MyAutoMapper.Profiles
{
    public class PersonneProfile: Profile
    {
        public PersonneProfile()
        {
            CreateMap<Personne, PersonneDTO>()
                .ForMember(poDesti => poDesti.NomComplet, opt => opt.MapFrom(poSource => $"{poSource.Nom} - {poSource.Prenom}"));
        }
    }
}
