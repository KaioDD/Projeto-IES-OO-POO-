using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoProjeto
{
    public class Instituicao
    {
        public string Nome {get;set;}
        public Endereco Endereco { get;set;}
        public Departamento[] Departamentos { get; } = new Departamento[10];
        //array do tipo departamento que irá armazenar todos os dptos criados. 
        private int quantidadadeDeDepartamentos = 0;
        public void RegistrarDepartamento(Departamento d)
        {
            if (quantidadadeDeDepartamentos < 10)
                Departamentos[quantidadadeDeDepartamentos++] = d; 
        }
        public int obterQuantidadeDeDepartamentos()
        {
            return quantidadadeDeDepartamentos;
        }
        public Departamento DepartamentoPorIndice(int indice)
        {
            return Departamentos[indice];
        }



    }
}
