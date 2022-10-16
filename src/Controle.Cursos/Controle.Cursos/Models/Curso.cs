﻿using Controle.Cursos.Constantes;
using Controle.Cursos.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Controle.Cursos.Models
{
    [Table("Curso")]
    public class Curso
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = ErrorMessage.NOME_OBRIGATORIO)]
        public string Nome { get; set; }
        public DateTime Horario { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public EModalidade Modalidade { get; set; }
        public IEnumerable<Turma> Turmas { get; set; }
    }
}