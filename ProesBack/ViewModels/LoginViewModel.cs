﻿using System.ComponentModel.DataAnnotations;

namespace ProesBack.ViewModels
{
    public class LoginViewModel
    {
        [Key]
        [Required(ErrorMessage = "O campo ID é obrigatório")]
        public int Id { get; set; }

        [Display(Name ="Usuario")]
        [Required(ErrorMessage = "O campo Usuario é obrigatório")]
        [MaxLength(50, ErrorMessage = "O campo Usuario deve ter no máximo 50 caracteres")]
        public string Username { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "O campo Senha é obrigatório")]
        [MaxLength(50, ErrorMessage = "O campo Senha deve ter no máximo 50 caracteres")]
        public string Password { get; set; }
    }
}
