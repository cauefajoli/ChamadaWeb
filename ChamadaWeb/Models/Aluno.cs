﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChamadaWeb.Models
{
    public class Aluno
    {
        [Key]
        public int ra { get; set; }
        public string Nome { get; set; }
        public ICollection<Curso> Cursos { get; set; }
    }
}