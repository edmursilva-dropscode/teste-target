using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartaPergunta
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool continueRunning = true;

            // Exibe a pergunta principal uma única vez
            Console.Clear();
            Console.WriteLine("Descubra a lógica e complete o próximo elemento:");
            Console.WriteLine();

            while (continueRunning)
            {                

                // Exibe todas as alternativas e suas descrições
                DisplayQuestionsAndDescriptions();

                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para exibir novamente ou ESC para sair...");
                var key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Escape)
                {
                    continueRunning = false;
                }
            }

            Console.WriteLine("Programa encerrado.");

        }
        static void DisplayQuestionsAndDescriptions()
        {

            // Perguntas e respostas
            Console.WriteLine("a) 1, 3, 5, 7, ___");
            Console.WriteLine("   Resposta é: 9");
            Console.WriteLine("   Descrição: A sequência é uma progressão aritmética com diferença constante de 2. O próximo número é 7 + 2.");
            Console.WriteLine();

            Console.WriteLine("b) 2, 4, 8, 16, 32, 64, ____");
            Console.WriteLine("   Resposta é: 128");
            Console.WriteLine("   Descrição: Cada número é o dobro do anterior, formando uma progressão geométrica com razão 2. O próximo número é 64 * 2.");
            Console.WriteLine();

            Console.WriteLine("c) 0, 1, 4, 9, 16, 25, 36, ____");
            Console.WriteLine("   Resposta é: 49");
            Console.WriteLine("   Descrição: A sequência é formada pelos quadrados dos números naturais (0², 1², 2², 3², ...). O próximo número é 7².");
            Console.WriteLine();

            Console.WriteLine("d) 4, 16, 36, 64, ____");
            Console.WriteLine("   Resposta é: 100");
            Console.WriteLine("   Descrição: A sequência é formada pelos quadrados dos números pares (2², 4², 6², 8², ...). O próximo número é 10².");
            Console.WriteLine();

            Console.WriteLine("e) 1, 1, 2, 3, 5, 8, ____");
            Console.WriteLine("   Resposta é: 13");
            Console.WriteLine("   Descrição: A sequência é a sequência de Fibonacci, onde cada número é a soma dos dois números anteriores. O próximo número é 5 + 8.");
            Console.WriteLine();

            Console.WriteLine("f) 2, 10, 12, 16, 17, 18, 19, ____");
            Console.WriteLine("   Resposta é: 20");
            Console.WriteLine("   Descrição: A sequência é uma combinação de padrões. Aqui, estamos seguindo a sequência dos números naturais excluindo múltiplos de 7. O próximo número é 20.");
            Console.WriteLine();
        }
    }
}
