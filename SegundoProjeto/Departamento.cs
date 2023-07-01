using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoProjeto
{
    internal class Departamento
    {
        public Departamento(string nome)
        {
            Nome = nome;
        }

        public string Nome {get;set;}
        public IList<Curso> Cursos { get; } = new List<Curso>();

        public void RegistrarCurso(Curso c)
        {
            Cursos.Add(c);
        }

        public int ObterQuantidadeDeCursos()
        {
            return Cursos.Count;
        }
        public Curso ObterCursoPorIndice(int indice)
        {
            return Cursos[indice];
        }
        
    }
}
