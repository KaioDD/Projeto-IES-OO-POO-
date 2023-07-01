using SegundoProjeto;
using System.ComponentModel.DataAnnotations;

internal class Program
{
    private static void Main(string[] args)
    {
        var iesUTFPR = new Instituicao()
        {
            Nome = "UTFPR",
            Endereco = new Endereco()
            {
                Rua = "Rua dos Banzeiros",
                Numero = "1000"
            }

        };
        var iesCC = new Instituicao()
        {
            Nome = "Casa do Codigo",
            Endereco= new Endereco()
            {
                Rua = "Avenida Europa",
                Numero = "354"
            }
        };


        var dptoDeEnsino = new Departamento("Computação");
        var dptoAlimentos = new Departamento("Alimentos");
        var dptoRevisao = new Departamento("Revisao Escrita");
   

        iesUTFPR.RegistrarDepartamento(dptoDeEnsino);
        iesUTFPR.RegistrarDepartamento(dptoAlimentos);
        iesUTFPR.RegistrarDepartamento(dptoRevisao);

        iesCC.RegistrarDepartamento(dptoAlimentos);
        iesCC.RegistrarDepartamento(dptoRevisao);
        iesCC.RegistrarDepartamento(dptoDeEnsino);


        Console.WriteLine("UTFPR");
        for (int i = 0; i < iesUTFPR.obterQuantidadeDeDepartamentos(); i++)
        {
            Console.WriteLine($"==> {iesUTFPR.Departamentos[i].Nome}");
        }

        Console.WriteLine("Casa do Codigo");
        for (int i = 0; i < iesCC.obterQuantidadeDeDepartamentos(); i++)
        {
            Console.WriteLine($"==> {iesCC.Departamentos[i].Nome}");
        }

        Console.WriteLine("APerte qualquer tecla para finalizar");
        Console.ReadKey();

        dptoAlimentos.RegistrarCurso(new Curso { Nome = "tecnologia em alimentos", CargarHoraria = 2000 });

    }
}