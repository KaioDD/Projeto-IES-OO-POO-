using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoProjeto
{
    public class Disciplina 
    {
        public string Nome {get;set;}
        public int CargaHoraria { get;set;}

        public override bool Equals(object obj)
        {
            if (obj is Disciplina)
            {
                Disciplina d = obj as Disciplina;
                return this.Nome.Equals(d.Nome);
            }
            return false;
        }
    }
}
