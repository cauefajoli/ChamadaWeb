using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChamadaWeb.Models
{
    public class Professor
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public ICollection<Curso> Cursos { get; set; }
    }
}