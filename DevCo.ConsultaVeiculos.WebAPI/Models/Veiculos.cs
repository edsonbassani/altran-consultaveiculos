using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DevCo.ConsultaVeiculos.WebAPI.Models
{
    public class Veiculos
    {
        [Key]
        public int IdVeiculo { get; set; }

        [BindProperty]
        [Required]
        [MaxLength(7)]
        [Column(TypeName = "varchar(7)")]
        public string Placa { get; set; }

        [Required]
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string Proprietario { get; set; }

        [Required]
        [Column(TypeName = "bit")]
        public bool Veiculo_Roubado { get; set; }

        [Required]
        [Column(TypeName = "smallint")]
        public short Ano_Fabricacao { get; set; }

        [Required]
        [Column(TypeName = "smallint")]
        public short Ano_Modelo { get; set; }
    }
}
