using AutoMapper;
using MoviesAPI.Data.Dtos.Gerente;
using MoviesAPI.Models;

namespace MoviesAPI.Profiles
{
    public class GerenteProfile: Profile
    {
        public GerenteProfile()
        {
            CreateMap<CreateGerenteDto, Gerente>();
            CreateMap<Gerente, ReadGerenteDto>();
        }
    }
}
