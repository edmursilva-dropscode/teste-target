using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuintaPergunta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Limpa a tela
                Console.Clear();

                // Exibindo a pergunta e alternativas com explicações
                DisplayQuestionAndDescriptions();

                Console.WriteLine("Pressione qualquer tecla para repetir ou ESC para sair...");

                // Aguarda o usuário pressionar uma tecla e verifica se é ESC
                var teclaFinal = Console.ReadKey(true).Key;
                if (teclaFinal == ConsoleKey.Escape)
                {
                    break; // Sai do loop principal e encerra o programa
                }
            }
        }

        // Função para exibir a pergunta e as descrições das alternativas
        static void DisplayQuestionAndDescriptions()
        {
            Console.WriteLine("Você está em uma sala com três interruptores, cada um conectado a uma lâmpada em salas diferentes.");
            Console.WriteLine("Você não pode ver as lâmpadas da sala em que está, mas pode ligar e desligar os interruptores quantas vezes quiser.");
            Console.WriteLine("Seu objetivo é descobrir qual interruptor controla qual lâmpada usando apenas duas idas até as salas das lâmpadas.");
            Console.WriteLine();

            Console.WriteLine("Aqui está como você pode identificar cada lâmpada:");
            Console.WriteLine("1. Ligue o primeiro interruptor e deixe-o ligado por 10-15 minutos.");
            Console.WriteLine("2. Após esse tempo, desligue o primeiro interruptor e ligue o segundo interruptor.");
            Console.WriteLine("3. Vá até as salas das lâmpadas e observe as lâmpadas:");
            Console.WriteLine("   - A lâmpada que está acesa é controlada pelo segundo interruptor.");
            Console.WriteLine("   - A lâmpada que está apagada, mas quente ao toque, é controlada pelo primeiro interruptor.");
            Console.WriteLine("   - A lâmpada que está apagada e fria é controlada pelo terceiro interruptor.");
            Console.WriteLine();

            Console.WriteLine("Alternativas:");
            Console.WriteLine("a) Lâmpada 1: Controlada pelo interruptor 2.");
            Console.WriteLine("b) Lâmpada 2: Controlada pelo interruptor 1.");
            Console.WriteLine("c) Lâmpada 3: Controlada pelo interruptor 3.");
            Console.WriteLine();

            Console.WriteLine("Respostas e explicações:");
            Console.WriteLine("a) Lâmpada 1: Controlada pelo interruptor 2. (A lâmpada está acesa quando você vai até lá.)");
            Console.WriteLine("b) Lâmpada 2: Controlada pelo interruptor 1. (A lâmpada está apagada, mas quente ao toque.)");
            Console.WriteLine("c) Lâmpada 3: Controlada pelo interruptor 3. (A lâmpada está apagada e fria.)");
        }
    }
}
