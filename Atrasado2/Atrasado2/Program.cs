using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avaliacao_360
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pontuacao = 0;
            int idade = 0;
            bool flag = false;

            try
            {
                while (!flag)
                {
                    Console.WriteLine("Digite sua idade ou 'S' para sair do programa.");
                    string inputIdade = Console.ReadLine();

                    if (inputIdade.ToUpper() == "S")
                    {
                        Console.WriteLine("Programa finalizado.");
                        return;
                    }

                    try
                    {
                        idade = int.Parse(inputIdade);
                        if (idade < 18 || idade > 75)
                        {
                            Console.WriteLine("Erro, Digite uma idade valida.");
                            continue;
                        }
                        flag = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Erro, Digite um número valido.");
                    }
                }

                flag = false;

                while (!flag)
                {
                    Console.WriteLine("Digite sua Pontuação entre para saber se esta no rank ou 'S' para sair.");
                    string inputPontuacao = Console.ReadLine();

                    if (inputPontuacao.ToUpper() == "S")
                    {
                        Console.WriteLine("Programa finalizado.");
                        return;
                    }

                    try
                    {
                        pontuacao = int.Parse(inputPontuacao);
                        if (pontuacao < 1 || pontuacao > 100)
                        {
                            Console.WriteLine("Erro, Digite um número valido.");
                            continue;
                        }
                        flag = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Erro, Digite um número valido.");
                    }

                    Console.WriteLine($"Sua pontuação foi de {pontuacao} e sua idade é {idade}");

                    if (pontuacao >= 75 && idade >= 18 && idade <= 25)
                    {
                        Console.WriteLine("parabens vc esta no rank.");
                    }
                    else
                    {
                        Console.WriteLine("voce não esta no rank.");
                    }
                }
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}