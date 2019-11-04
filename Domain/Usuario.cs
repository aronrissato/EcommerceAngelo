using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    [Table("Usuarios")]

    public class Usuario
    {
        public Usuario()
        {
            CriadoEm = DateTime.Now;
        }

        [Key]
        public int UsuarioId { get; set; }

        [Display(Name = "Email:")]
        [EmailAddress(ErrorMessage = "Email inválido!")]
        public string Email { get; set; }

        [Display(Name = "Senha:")]
        public string Senha { get; set; }

        [NotMapped]
        [Display(Name = "Confirmação de senha:")]
        [Compare("Senha", ErrorMessage = "As senhas não são idênticas!")]
        public string ConfirmacaoSenha { get; set; }

        public Endereco Endereco { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}
