using AutoMapper;
using MoviesAPI.Data.Dtos;
using MoviesAPI.Models;

namespace MoviesAPI.Profiles
{
    public class SessaoProfile : Profile
    {
        public SessaoProfile()
        {
            CreateMap<CreateSessaoDto, Sessao>();
            CreateMap<Sessao, ReadSessaoDto>()
                .ForMember(dto => dto.HorarioDeInicio, opts => opts
                .MapFrom(Dto =>
                Dto.HorarioDeEncerramento.AddMinutes(Dto.Filme.Duracao * (-1))));
        }
    }
}
