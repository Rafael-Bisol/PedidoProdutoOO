namespace PedidoProdutoOO
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quant;

        public double ValorTotal
        {
            get
            {
                double valor = preco * (double)quant;
                if (quant >= 11 && quant <= 20)
                    valor -= valor * 10/100;
                else if (quant >= 21 && quant <= 50)
                    valor -= valor * 20/100;
                else if (quant > 50)
                    valor -= valor * 25/100;
                
                return valor;
            }
        }
    }
}