using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SegundoProjeto
{
    public class Endereco
    {
        public string Rua {get;set;}
        public string Numero { get;set;}    
        public string Bairro { get;set;}

        public static implicit operator Endereco(string v)
        {
            throw new NotImplementedException();
        }
    }
}
