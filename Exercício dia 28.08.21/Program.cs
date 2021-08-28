using System;

namespace Exercício_dia_28._08._21
{
    class Program
    {
        static void Main(string[] args)
        {
            double profundidade, largura, altura, porta, janela;

            //ENTRADA
            
            Console.WriteLine("Informe as mediadas do cômodo: ");

            Console.Write("Largura: ");
            largura = double.Parse(Console.ReadLine());

            Console.Write("Altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.Write("Profundidade: ");
            profundidade = double.Parse(Console.ReadLine());

            Console.Write("Informe o tamanho da porta em metros, se não houver digite zero(0): ");
            porta = double.Parse(Console.ReadLine());

            Console.Write("Informe o tamanho da janela em metros, se houver mais de uma informe os valores somados. Senão digite zero(0): ");
            janela = double.Parse(Console.ReadLine());

            //PROCESSAMENTO

            double desconto = janela + porta;

            double areaParede = altura * (largura + profundidade) * 2 - desconto;

            double areaTeto = largura * altura;

            double litragem = Math.Round((areaParede + areaTeto) / 2,9);

            //SAÍDA

            Console.WriteLine($"A area das paredes é de: {areaParede} m.");

            Console.WriteLine($"A area do teto é de: {areaTeto} m.");

            Console.WriteLine($"Serão necessários {litragem} litros de tinta.");
        }
    }
}
