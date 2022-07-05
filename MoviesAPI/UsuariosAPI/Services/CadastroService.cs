using AutoMapper;
using FluentResults;
using Microsoft.AspNetCore.Identity;
using System;
using System.Linq;
using System.Threading.Tasks;
using UsuariosAPI.Data.Dtos;
using UsuariosAPI.Data.Requests;
using UsuariosAPI.Models;

namespace UsuariosAPI.Services
{
    public class CadastroService
    {

        private IMapper _mapper;
        private UserManager<IdentityUser<int>> _userManager;

        public CadastroService(IMapper mapper, UserManager<IdentityUser<int>> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }
        public Result CadastraUsuario(CreateUsuarioDto cadastroDto)
        {
            Usuario usuario = _mapper.Map<Usuario>(cadastroDto);
            IdentityUser<int> usuarioIdentity = _mapper.Map<IdentityUser<int>>(usuario);
            Task<IdentityResult> resultado = _userManager
                .CreateAsync(usuarioIdentity, cadastroDto.Password);

            if (resultado.Result.Succeeded)
            {
                var code = _userManager.GenerateEmailConfirmationTokenAsync(usuarioIdentity).Result;
                return Result.Ok().WithSuccess(code);
            }
            return Result.Fail("Falha ao cadastrar usuário");
        }

        public Result AtivaContaUsuario(AtivaContaRequest request)
        {
            var identityUser = _userManager
                .Users
                .FirstOrDefault(u => u.Id == request.UsuarioId);
            var identityResult = _userManager.ConfirmEmailAsync(identityUser, request.CodigoDeAtivacao).Result;

            if (identityResult.Succeeded)
            {
                return Result.Ok();
            }
            return Result.Fail("Falha ao ativar conta de usuário");
        }
    }
}
