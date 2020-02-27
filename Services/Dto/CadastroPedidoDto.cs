using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Services.Dto
{
    public class CadastroPedidoDto
    {
        [Required(ErrorMessage = "O campo IdSabor é obrigatório")]
        public int? IdSabor { get; set; }
        [Required(ErrorMessage = "O campo IdTamanho é obrigatório")]
        public int? IdTamanho { get; set; }
        public List<PersonalizacaoDto> Personalizacao { get; set; }

    }
}
