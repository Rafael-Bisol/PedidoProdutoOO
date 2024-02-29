using System;

namespace PedidoProdutoOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Pedido de um produto");
            Console.Write("Digite o nome do produto: ");
            produto.nome = Console.ReadLine();
            Console.Write("Digite o preço unitário do produto: ");
            produto.preco = double.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade comprada: ");
            produto.quant = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"O valor total do produto é {produto.valorTotal}");
        }
    }
}
