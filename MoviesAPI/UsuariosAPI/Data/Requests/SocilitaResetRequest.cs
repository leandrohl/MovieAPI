﻿using System.ComponentModel.DataAnnotations;

namespace UsuariosAPI.Data.Requests
{
    public class SocilitaResetRequest
    {
        [Required]
        public string Email { get; set; }

    }
}
