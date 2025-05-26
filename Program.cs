using CSharpCourse.ClassesEMetodos;
using CSharpCourse.Colecoes;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;

namespace CSharpCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Classes e Métodos
            Membros.Executar();
            Construtores.Executar();
            MetodosComRetorno.Executar();
            MetodosEstaticos.Executar();
            AtributosEstaticos.Executar();
            DesafioAtributo.Executar();
            Params.Executar();
            ParametrosNomeados.Executar();
            GetSet.Executar();
            Propriedades.Executar();
            Readonly.Executar();
            ExemploStruct.Executar();
            StructVsClasse.Executar();
            ValorVsReferencia.Executar();
            ParametrosPorReferencia.Executar();
            ParametroPadrao.Executar();

            //Coleções
            ColecoesArray.Executar();
            ColecoesList.Executar();
            ColecoesArrayList.Executar();
            ColecoesSet.Executar();
            ColecoesQueue.Executar();
            ColecoesIgualdade.Executar();
            ColecoesStack.Executar();
            ColecoesDictionary.Executar();
            
            //O.O
            Heranca.Executar();
            ConstrutorThis.Executar();
        }
    }
}