using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A31OPoderDosSets
{
     class Program
    {
        static void Main(string[] args)
        {
            //declarando set de alunos
            ISet<string> alunos = new HashSet<string>();
            //adicionando: vanessa, ana, rafael
            alunos.Add("Vanessa Tonini");
            alunos.Add("Ana Losnak");
            alunos.Add("Rafael Nercessian");

            //imprimindo
            Console.WriteLine(alunos);
            Console.WriteLine(string.Join(",", alunos));

            //qual a diferença para uma lista?? vamos ver agora 

            //adicionando: priscila, rollo, fabio
            alunos.Add("Priscila Stuani");
            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gushiken");
            Console.WriteLine(string.Join(",", alunos));
            // e a ordem???

            //removendo Ana, adicionando marcelo
            alunos.Remove("Ana Losnak");
            alunos.Add("Marcelo Oliveira");
            //imprimindo de novo
            Console.WriteLine(string.Join(",", alunos));
            //adicionando gushiken de novo
            alunos.Add("Fabio Gushiken");
            Console.WriteLine(string.Join(",", alunos));

            //qual a vantagem do set sobre a lista? look-up!

            //desempenho HashSet X List: escalabilidade X memória

            //mudar ISet para ICollection p/ deixar mais flexível

            //ordenando: sort
            //alunos.Sort();
            //copiando: alunosEmLista
            List<string> alunosEmLista = new List<string>(alunos);
            //ordenando cópia
            alunosEmLista.Sort();
            //imprimindo cópia
            Console.WriteLine(string.Join(",", alunosEmLista));



        }
    }
}
