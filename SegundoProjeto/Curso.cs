using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SegundoProjeto
{
    public class Curso
    {
        public string Nome {get; set;}
        public int CargarHoraria { get; set; }
        public HashSet<Disciplina> Disciplinas { get; } = new HashSet<Disciplina>();
        public void RegistrarDisciplina(Disciplina d)
        {
            Disciplinas.Add(d);
        }
        public int ObterQuantidadeDisciplinasNoCurso()
        {
            return Disciplinas.Count; 
        }


        public override bool Equals(object obj)
            // override = reescreve o metodo equals da classe object (SuperClasse). 
            //
        {
            if (obj is Curso)
            //Is" é usado para verificar se um objeto é de um determinado tipo.
            {
                Curso c = obj as Curso;
                //as é usado para realizar uma conversão de tipos segura, retornando null caso a conversão não seja possível.
                return this.Nome.Equals(c.Nome);

            }
            return false;
        }
        public override int GetHashCode()
        {
            return 11 + this.Nome == null ? 0 : this.Nome.GetHashCode();
        }

    }
}
