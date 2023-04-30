using System.ComponentModel.DataAnnotations;

namespace ProEventos.Application.Dtos
{
    public class EventoDto
    {
        
        public int Id { get; set; }
        public string Local { get; set; }
        public string DataEvento { get; set; }

        [Required(ErrorMessage = "O {0} é Obrigatório. "),
         StringLength(50, MinimumLength = 3, ErrorMessage = "O {0} deve possuir de 3 a 50 caracteres")]
        public string Tema { get; set; }

        [Display(Name = "Qtd Pessoas"),
         Range(1, 120000, ErrorMessage = "{0} não pode ser menor que  1 e maior que 120.000")]
        public int QtdPessoas { get; set; }

        [RegularExpression(@".*\.(gif|jpe?g|bmp|png)$", ErrorMessage = "Não é uma imagem válida (gif, jpg, bmp, png)")]
        public string ImagemURL { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório"),
         Phone(ErrorMessage = "{0} inválido")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório"),
         Display(Name = "e-mail"),
         EmailAddress(ErrorMessage = "Informe um {0} válido")]
    public string Email { get; set; }
        
        public IEnumerable<LoteDto> Lotes { get; set; }
        public IEnumerable<RedeSocialDto> RedesSociais { get; set; }
        public IEnumerable<PalestranteDto> Palestrantes { get; set; }
    }
}