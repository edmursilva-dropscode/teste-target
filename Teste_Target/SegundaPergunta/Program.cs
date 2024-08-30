using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaPergunta
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Digite uma string para verificar a quantidade de letras 'a' e 'A' e ENTER resultado ou pressione ESC para sair:");

                StringBuilder inputBuilder = new StringBuilder();
                ConsoleKeyInfo tecla;

                while (true)
                {
                    tecla = Console.ReadKey(intercept: true);

                    if (tecla.Key == ConsoleKey.Escape)
                    {
                        return;
                    }

                    if (tecla.Key == ConsoleKey.Enter)
                    {
                        break;
                    }

                    if (tecla.Key == ConsoleKey.Backspace)
                    {
                        // Remove o último caractere do StringBuilder e apaga o caractere da tela
                        if (inputBuilder.Length > 0)
                        {
                            inputBuilder.Length--; // Remove o último caractere do StringBuilder
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            Console.Write(" ");
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                        }
                    }
                    else if (!char.IsControl(tecla.KeyChar))
                    {
                        inputBuilder.Append(tecla.KeyChar);
                        Console.Write(tecla.KeyChar);
                    }
                }

                string input = inputBuilder.ToString();
                int quantidadeA = ContarLetrasA(input);

                Console.WriteLine($"\nA letra 'a' (tanto maiúscula quanto minúscula) aparece {quantidadeA} vez(es) na string.");

                Console.WriteLine("Pressione qualquer tecla para continuar ou ESC para sair...");

                var teclaFinal = Console.ReadKey(true).Key;
                if (teclaFinal == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }

        // Método para contar a quantidade de letras 'a' e 'A' em uma string
        static int ContarLetrasA(string texto)
        {
            int count = 0;

            // Percorre cada caractere da string
            foreach (char c in texto)
            {
                // Verifica se o caractere é 'a' ou 'A'
                if (c == 'a' || c == 'A')
                {
                    count++;
                }
            }

            return count;
        }

    }
}
