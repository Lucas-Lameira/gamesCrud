using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.InputModel
{
    public class JogoInputModel
    {
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Nome inválido")]
        public string Nome { get; set;}
        [Required]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Nome da produtora inválido")]
        public string Produtora { get; set; }
        [Required]
        [Range(1, 1000, ErrorMessage = "Preco inválido")]
        public double Preco { get; set; }
    }
}
