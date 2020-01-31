using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Senai.CodeTur.Dominio.Entidades
{
    [Table("Pacotes")]
    public class PacoteDominio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("Nome", TypeName = "varchar(85)")]
        public string Nome { get; set; }

        [Required]
        [Column("Pais", TypeName = "varchar(58)")]
        public string Pais { get; set; }

        [Required]
        [Column("DataInicio", TypeName = "datetime")]
        public DateTime DataInicio { get; set; }

        [Required]
        [Column("DataChegada", TypeName = "datetime")]
        public DateTime DataFim { get; set; }

        [Required]
        [Column("Descricao", TypeName = "varchar(500)")]
        public string Descricao { get; set; }

        [Required]
        [Column("Ativo", TypeName = "bit")]
        public bool Ativo { get; set; }

        [Required]
        [Column("Imagem", TypeName = "varchar(350)")]
        public string Imagem { get; set; }
    }
}
