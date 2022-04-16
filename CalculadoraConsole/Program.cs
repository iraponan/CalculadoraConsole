using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConsole {
    internal class Program {
        static void Main(string[] args) {
            Console.Clear();

            menu();

            //Pause do console no final da aplicação... Fica aguardando o usuario apertar qualquer tecla para fecharo console.
            Console.ReadKey();
        }

        static void menu() {
            Console.WriteLine("Calculadora\n" +
                "Escola uma das operações abaixo.\n" +
                "1 - Soma\n" +
                "2 - Subtração\n" +
                "3 - Multiplicação\n" +
                "4 - Divisão");

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
            }
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
            Console.Write("O Resultado da Soma é: " + (result.Item1 + result.Item2));
        }

        static void subtracao() {
            var result = dadosDeEntrada();
            Console.Write("O Resultado da Substração é: " + (result.Item1 - result.Item2));
        }

        static void multiplicacao() {
            var result = dadosDeEntrada();
            Console.Write("O Resultado da Multiplicação é: " + (result.Item1 * result.Item2));
        }
    }
}
