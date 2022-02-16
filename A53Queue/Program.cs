using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A53Queue
{
    internal class Program
    {
        static Queue<string> pedagio = new Queue<string>();
        static void Main(string[] args)
        {
            //entrou: van
            Enfileirar("van");
            //entrou: kombi
            Enfileirar("kombi");
            //entrou: guincho
            Enfileirar("guincho");
            //entrou: pickup
            Enfileirar("pickup");

            //carro liberado
            Desenfileirar();
            //carro liberado
            Desenfileirar();
            //carro liberado
            Desenfileirar();
            //carro liberado
            Desenfileirar();
            //carro liberado
            Desenfileirar();

            Console.ReadLine();
            Console.WriteLine("Prescione qualquer tecla para fechar o programa. . .");
        }

        private static void Desenfileirar()
        {
            if (pedagio.Any())
            {
                if (pedagio.Peek() == "guincho")
                {
                    Console.WriteLine("guincho está fazendo o pagamento");
                }
                string veiculo = pedagio.Dequeue();
                Console.WriteLine($"Saiu da filar: {veiculo}");
                ImprimirFila();
            }
        }

        private static void Enfileirar(string veiculo)
        {
            Console.WriteLine($"Entrou na fila: {veiculo}");
            pedagio.Enqueue(veiculo);
            ImprimirFila();
        }

        private static void ImprimirFila()
        {
            Console.WriteLine("FILA:");
            foreach (var v in pedagio)
            {
                Console.WriteLine(v);
            }
        }
    }
}
