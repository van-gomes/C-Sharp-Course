namespace CSharpCourse.ClassesEMetodos;

public class DesafioAtributo
{
    int a = 10;

    public DesafioAtributo(int a)
    {
        this.a = a;
    }
    
    public static void Executar() {
     var a = new DesafioAtributo(a: 10);

     Console.WriteLine(a);
    }
}