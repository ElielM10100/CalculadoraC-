using System;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Escolha uma operação:");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("0 - Sair");

                // Recebe a escolha do usuário
                Console.Write("Digite o número da operação desejada: ");
                string escolha = Console.ReadLine();

                // Sai do loop se o usuário escolher 0
                if (escolha == "0")
                    break;

                // Variáveis para armazenar números de entrada
                double? num1, num2;

                // Solicita os números ao usuário
                Console.Write("Digite o primeiro número: ");
                if (!double.TryParse(Console.ReadLine(), out double parsedNum1))
                {
                    Console.WriteLine("Entrada inválida. Certifique-se de inserir um número válido.");
                    continue;
                }
                num1 = parsedNum1;

                Console.Write("Digite o segundo número: ");
                if (!double.TryParse(Console.ReadLine(), out double parsedNum2))
                {
                    Console.WriteLine("Entrada inválida. Certifique-se de inserir um número válido.");
                    continue;
                }
                num2 = parsedNum2;

                // Realiza a operação escolhida
                double? resultado = null;
                switch (escolha)
                {
                    case "1":
                        resultado = num1 + num2;
                        break;
                    case "2":
                        resultado = num1 - num2;
                        break;
                    case "3":
                        resultado = num1 * num2;
                        break;
                    case "4":
                        if (num2 != 0)
                            resultado = num1 / num2;
                        else
                            Console.WriteLine("Erro: Divisão por zero.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                // Exibe o resultado
                if (resultado.HasValue)
                    Console.WriteLine($"Resultado: {resultado}");
                else
                    Console.WriteLine("A operação não pôde ser concluída.");
            }

            Console.WriteLine("Calculadora encerrada. Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}
