using CSharpCourse.ClassesEMetodos;
using CSharpCourse.Colecoes;
using CursoCSharp.Api;
using CursoCSharp.Colecoes;
using CursoCSharp.Excecoes;
using CursoCSharp.MetodosEFuncoes;
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
            CursoCSharp.OO.Encapsulamento.Executar();
            Polimorfismo.Executar();
            Abstract.Executar();
            Interface.Executar();
            Sealed.Executar();
            
            //Métodos e Funções
            ExemploLambda.Executar();
            LambdasDelegate.Executar();
            UsandoDelegates.Executar();
            DelegateFunAnonima.Executar();
            DelegatesComoParametros.Executar();
            MetodosDeExtensao.Executar();
            
            //Exceções
            PrimeiraExcecao.Executar();
            ExcecoesPersonalizadas.Executar();
            
            //Explorando API C#
            PrimeiroArquivo.Executar();
            LendoArquivos.Executar();
            //ExemploFileInfo.Executar();
            //Diretorios.Executar();
            //ExemploDirectoryInfo.Executar();
            //ExemploPath.Executar();
            //ExemploTimeSpan.Executar();
        }
    }
}