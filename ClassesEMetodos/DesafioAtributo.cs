namespace CSharpCourse.ClassesEMetodos;

class DesafioAtributo
{
    int a = 10;

    public static void Executar()
    {
        // Acessar variável 'a' dentro do método Executar!
        // Console.WriteLine(a);

        DesafioAtributo desafio = new DesafioAtributo();
        Console.WriteLine(desafio.a);
    }
}