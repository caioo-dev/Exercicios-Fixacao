using System.Globalization;

namespace CarrinhoDeCompras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carrinho carrinho = new Carrinho();

            Produto arroz = new Produto("Arroz", 5.99, 2);
            Produto feijao = new Produto("Feijão", 8.49, 1);
            Produto arrozMais = new Produto("Arroz", 5.99, 3); // mesma descrição para testar soma de quantidade

            carrinho.AdicionarProduto(arroz);
            carrinho.AdicionarProduto(feijao);
            carrinho.AdicionarProduto(arrozMais); // deve somar com o "arroz" anterior

            Console.WriteLine("\nProdutos no carrinho:");
            carrinho.ExibirTodosProdutos();

            Console.WriteLine($"\nTotal da compra: R$ {carrinho.CalcularTotal():F2}");

            carrinho.RemoverQuantidadesProduto(arroz, 3); // simula input e subtrai

            Console.WriteLine("\nApós remover quantidades de arroz:");
            carrinho.ExibirTodosProdutos();

            Console.WriteLine($"\nTotal atualizado: R$ {carrinho.CalcularTotal():F2}");
        }
    }
}
