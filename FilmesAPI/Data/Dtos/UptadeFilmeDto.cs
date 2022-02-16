using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Data.Dtos
{
    public class UpdateFilmeDto
    {
        //Obrigatorio
        [Required(ErrorMessage = "O campo título é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo diretor é obrigatório")]
        public string Diretor { get; set; }
        //Limite de caracteres
        [StringLength(50, ErrorMessage = "O gênero não pode estrapolar de 50 caracteres")]
        public string Genero { get; set; }
        //Limite de tempo minimo
        [Range(1, 500, ErrorMessage = "A duração deve ter no minimo 1 e no maximo 500 minutos")]
        public int Duracao { get; set; }
    }
}
