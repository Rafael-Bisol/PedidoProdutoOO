using System;

namespace PedidoProdutoOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pedido de um produto");
            Console.Write("Digite o nome do produto: ");
            string produto = Console.ReadLine();
            Console.Write("Digite o preço unitário do produto: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade comprada: ");
            int quant = int.Parse(Console.ReadLine());

            double valorTotal = preco * (double)quant;
            
            if (quant >= 11 && quant <= 20)
                valorTotal *= (100 - 10) / 100;
            else if (quant >= 21 && quant <= 50)
                valorTotal *= 1 - 0.2;
            else if (quant > 50)
                valorTotal *= 1 - 25/100;
            
            Console.WriteLine($"O valor total do produto é {valorTotal}");
        }
    }
}
