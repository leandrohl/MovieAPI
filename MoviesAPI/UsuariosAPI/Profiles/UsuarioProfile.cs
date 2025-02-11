﻿using AutoMapper;
using Microsoft.AspNetCore.Identity;
using UsuariosAPI.Data.Dtos;
using UsuariosAPI.Models;

namespace UsuariosAPI.Profiles
{
    public class UsuarioProfile : Profile
    {

        public UsuarioProfile (){
            CreateMap<CreateUsuarioDto, Usuario>();
            CreateMap<Usuario, IdentityUser<int>>();
            CreateMap<Usuario, CustomIdentityUser>();

        }
    }
}
