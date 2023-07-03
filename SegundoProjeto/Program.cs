using SegundoProjeto;
using System.ComponentModel.DataAnnotations;

public class Program
{
    private static void Main(string[] args, int cargarHoraria)
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


        dptoAlimentos.RegistrarCurso(new Curso { Nome = "Engenharia em alimentos", CargarHoraria = 3000 } );

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"Cursos do Departamento {dptoAlimentos.Nome}");

        foreach (var curso in dptoAlimentos.Cursos)
        {
            Console.WriteLine($"==> {curso.Nome} ({curso.CargarHoraria}h)");
        }
        Console.WriteLine("APerte qualquer tecla para finalizar");
        Console.ReadKey();

        dptoAlimentos.FecharDepartamento();
        dptoAlimentos = null;
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("o departamento de alimentos foi fechado");

        var ctAlimentos = new Curso() { Nome = "tecnologia em alimentos", CargarHoraria = 2000 };

        if (!dptoAlimentos.Cursos.Contains(ctAlimentos))
        {
            ;
        }

        dptoAlimentos.RegistrarCurso(ctAlimentos);
     

    }
}