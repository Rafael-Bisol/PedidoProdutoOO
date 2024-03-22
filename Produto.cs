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
                double valor = Preco * (double)Quant;
                if (Quant >= 11 && Quant <= 20)
                    valor -= valor * 10/100;
                else if (Quant >= 21 && Quant <= 50)
                    valor -= valor * 20/100;
                else if (Quant > 50)
                    valor -= valor * 25/100;
                
                return valor;
            }
        }

        public Produto() {
            Nome = "";
            Preco = 0;
            Quant = 0;
        }
        public Produto(string nome) {
            Nome = nome;
        }
        public Produto(string nome, double preco) : this(nome) {
            Preco = preco;
        }
        public Produto(string nome, double preco, int quant) : this(nome, preco) {
            Quant = quant;
        }
    }
}