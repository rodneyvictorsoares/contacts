using System;
using System.ComponentModel.DataAnnotations;

namespace Presentation.DTOs
{
    public class ContatoDTO
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; private set; } = "";
        [Required]

        public string Email { get; set; } = "";
    }
}
