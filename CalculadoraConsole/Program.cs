using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConsole {
    internal class Program {
        static void Main(string[] args) {
            int opcao = 9;

            while (opcao != 0) {
                Console.Clear();
                opcao = menu(opcao);
            }
        }

        static int menu(int opcao) {
            Console.Write("###--- Calculadora ---###\n" +
                "Operações Disponíveis.\n" +
                "   1 - Soma\n" +
                "   2 - Subtração\n" +
                "   3 - Multiplicação\n" +
                "   4 - Divisão\n" +
                "   5 - Sair\n" +
                "------------------------------\n" +
                "Qual operação deseja executar? ");

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha) {
                case 1:
                    soma();
                    break;
                case 2: 
                    subtracao();
                    break;
                case 3:
                    multiplicacao();
                    break;
                case 4:
                    divisao();
                    break;
                case 5:
                    for (int i = 5; i > 0; i--) {
                        Console.WriteLine("Saindo em " + i);
                        System.Threading.Thread.Sleep(1000);
                    }
                    opcao = 0;
                    break;
                default:
                    Console.WriteLine("Opção invalida!!! Tente novamente...");
                    break;
            }

            if (aguardarUsuario(escolha)) {
                Console.WriteLine("\n\nAperte uma tecla para continuar...");
                Console.ReadKey();
            }
            return opcao;
        }

        static (float, float) dadosDeEntrada() {
            Console.Write("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            return (v1, v2);
        }

        static void soma() {            
            var result = dadosDeEntrada();
            Console.Write("O Resultado da Soma de " + result.Item1 + " + " + result.Item2 + " é: " + (result.Item1 + result.Item2));
        }

        static void subtracao() {
            var result = dadosDeEntrada();
            Console.Write("O Resultado da Substração de " + result.Item1 + " - " + result.Item2 + " é: " + (result.Item1 - result.Item2));
        }

        static void multiplicacao() {
            var result = dadosDeEntrada();
            Console.Write("O Resultado da Multiplicação de " + result.Item1 + " x " + result.Item2 + " é: " + (result.Item1 * result.Item2));
        }

        static void divisao() {
            var result = dadosDeEntrada();
            Console.Write("O Resultado da Divisão de " + result.Item1 + " ÷ " + result.Item2 + " é: " + (result.Item1 / result.Item2));
        }

        static bool aguardarUsuario(int escolha) {
            if (escolha == 5) {
                return false;
            }
            else {
                return true;
            }
        }
    }
}
