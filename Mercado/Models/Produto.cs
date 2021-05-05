using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mercado.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        [Range(1, 50, ErrorMessage = "Execedeu o valor de 50 caracteres")]
        public string Descricao { get; set; }
        public int Quantidade { get; set; }


        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }

        public Categoria Categorias { get; set; }
    }
}
