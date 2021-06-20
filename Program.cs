using System;

namespace Projeto_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string opcaoUsuario;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("---------------------");
            Console.WriteLine("Calculadora Alpha 365");
            Console.WriteLine("---------------------\n");
            Console.ResetColor();

            do
            {
                exibirMenu();

                Console.Write("Digite sua opção: ");
                Console.ResetColor();
                opcaoUsuario = Console.ReadLine();

                switch (opcaoUsuario)
                {
                    case "1":

                        exibirSoma();
                        break;

                    case "2":

                        exibirSubtracao();
                        break;

                    case "3":

                        exibirMultiplicacao();
                        break;

                    case "4":

                        exibirDivisao();
                        break;

                    case "5":

                        exibirExponenciacao();
                        break;

                    case "6":

                        exibirRadiciacao();
                        break;

                    case "7":

                        exibirSobre();
                        break;

                    case "0":
                        exibirSaida();
                        break;

                    default:
                        exibirErro();
                        break;
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nPressione qualquer tecla para continuar...");
                Console.ResetColor();
                Console.ReadKey();

                Console.Clear();

            } while (opcaoUsuario != "0");

        }


        static void exibirSoma()
        {
            double numero1, numero2;

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Soma escolhida");
            Console.WriteLine("---------------\n");

            Console.Write("\nDigite o primeiro número: ");
            Console.ResetColor();
            bool numeroValido = double.TryParse(Console.ReadLine(), out numero1);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nDigite o segundo número: ");
            Console.ResetColor();
            bool numeroValido1 = double.TryParse(Console.ReadLine(), out numero2);

            if (!numeroValido || !numeroValido1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nDigite apenas números.\n");
                Console.ResetColor();
            }

            else
            {
                double resultado = numero1 + numero2;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nA soma de {numero1} + {numero2} = {resultado}.\n");
                Console.ResetColor();

            }






        }


        static void exibirSubtracao()
        {
            double numero1, numero2;

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nSubtração escolhida");
            Console.WriteLine("---------------------\n");

            Console.Write("\nDigite o primeiro número: ");
            Console.ResetColor();
            bool numeroValido = double.TryParse(Console.ReadLine(), out numero1);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nDigite o segundo número: ");
            Console.ResetColor();
            bool numeroValido1 = double.TryParse(Console.ReadLine(), out numero2);

            if (!numeroValido || !numeroValido1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nDigite apenas números.\n");
                Console.ResetColor();
            }

            else
            {
                double resultado = numero1 - numero2;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nA subtração de {numero1} - {numero2} = {resultado}.\n");
                Console.ResetColor();

            }




        }


        static void exibirMultiplicacao()
        {
            double numero1, numero2;

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nMultiplicação escolhida");
            Console.WriteLine("------------------------\n");

            Console.Write("\nDigite o primeiro número: ");
            Console.ResetColor();
            bool numeroValido = double.TryParse(Console.ReadLine(), out numero1);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nDigite o segundo número: ");
            Console.ResetColor();
            bool numeroValido1 = double.TryParse(Console.ReadLine(), out numero2);

            if (!numeroValido || !numeroValido1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nDigite apenas números.\n");
                Console.ResetColor();
            }

            else
            {
                double resultado = numero1 * numero2;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nA multiplicação de {numero1} * {numero2} = {resultado}.\n");
                Console.ResetColor();

            }


        }


        static void exibirDivisao()
        {
            double dividendo, divisor;

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nDivisão escolhida");
            Console.WriteLine("-----------------\n");

            Console.Write("\nDigite o dividendo: ");
            Console.ResetColor();
            bool numeroValido = double.TryParse(Console.ReadLine(), out dividendo);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nDigite o divisor: ");
            Console.ResetColor();
            bool numeroValido1 = double.TryParse(Console.ReadLine(), out divisor);

            if (!numeroValido || !numeroValido1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nDigite apenas números.\n");
                Console.ResetColor();
            }

            else if (divisor == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nNão é possível dividir por {divisor}.");
                Console.ResetColor();
            }

            else
            {
                double resultado = dividendo / divisor;
                double resto = dividendo % divisor;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nA divisão de {dividendo} por {divisor} é {resultado}, o resto é {resto}.\n");
                Console.ResetColor();

            }


        }


        static void exibirExponenciacao()

        {
            double base1;
            double expoente;

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nExponenciação escolhida");
            Console.WriteLine("----------------------\n");

            Console.Write("\nDigite a base: ");
            Console.ResetColor();
            bool numeroValido = double.TryParse(Console.ReadLine(), out base1);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nDigite o expoente: ");
            Console.ResetColor();
            bool numeroValido1 = double.TryParse(Console.ReadLine(), out expoente);

            if (!numeroValido || !numeroValido1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nDigite apenas números.\n");
                Console.ResetColor();
            }

            else if (base1 == 0 )
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Não é possível ter potência de ({base1})");
                Console.ResetColor();
            }
            
            else
            {
                double potencia = Math.Pow(base1, expoente);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nA potência de {base1} elevado a {expoente} é {potencia}.\n");
                Console.ResetColor();

            }


        }


        static void exibirRadiciacao()
        {
            double numero1;

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nRadiação escolhida");
            Console.WriteLine("-----------------\n");

            Console.Write("\nDigite o numero: ");
            Console.ResetColor();
            bool numeroValido = double.TryParse(Console.ReadLine(), out numero1);


            if (!numeroValido)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nDigite apenas números.\n");
                Console.ResetColor();
            }

            else if (numero1 < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nNão existe raiz de números negativos ({numero1}) .\n");
                Console.ResetColor();
            }
            

            else
            {
                double resultado = Math.Sqrt(numero1);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nA raiz quadrada de {numero1} é {resultado}.\n");
                Console.ResetColor();
            }







        }


        static void exibirSobre()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nMe chamo Thiago, atualmente tenho 16 anos, estou no 2° Ano do ensino médio, estou cursando informática na Etec Adolpho Berezin.\n ");

            Console.WriteLine("Link do site do projeto:https://thiagoribeiro16.github.io/Projeto-Final/\n");
            Console.ResetColor();
        }


        static void exibirSaida()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nSaindo do programa...\n");
            Console.WriteLine("Obrigado por utilizar a calculadora Alpha 365.");
            Console.WriteLine("----------------------------------------------\n");
            Console.ResetColor();
        }


        static void exibirErro()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nOpcão inválida tente novamente.");
            Console.ResetColor();

        }


        static void exibirMenu()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nMenu de Opções");
            Console.WriteLine("--------------------\n");

            Console.WriteLine("[1]. Soma \n");

            Console.WriteLine("[2]. Subtração \n");

            Console.WriteLine("[3]. Multiplicação \n");

            Console.WriteLine("[4]. Divisão \n");

            Console.WriteLine("[5]. Exponenciação \n");

            Console.WriteLine("[6]. Radiciação \n");

            Console.WriteLine("[7]. Sobre \n");

            Console.WriteLine("[0]. Sair \n");

            Console.WriteLine("--------------------\n");
        }


    }
}
