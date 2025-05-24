namespace CarrinhoDeCompras
{
    internal class Carrinho
    {

        List<Produto> produtos = new List<Produto>();

        public void AdicionarProduto(Produto novo)
        {
            // Verifica se o produto já existe pelo nome
            var existente = produtos.FirstOrDefault(p => p.Descricao == novo.Descricao);

            if (existente != null)
            {
                // Atualiza a quantidade
                existente.Quantidade += novo.Quantidade;
            }
            else
            {
                produtos.Add(novo);
            }
        }

        public void RemoverProduto(Produto p)
        {
            produtos.Remove(p);
        }

        public void RemoverQuantidadesProduto(Produto p)
        {
            Console.WriteLine("Quantas quantidades do produto deseja remover? ");
            int qte = int.Parse(Console.ReadLine());

            p.Quantidade -= qte;

        }

        public double CalcularTotal()
        {
            double total = 0;
            foreach (var item in produtos)
            {
                total += item.Quantidade * item.Preco;
            }

            return total;
        }

        public void ExibirTodosProdutos()
        {
            foreach (var item in produtos)
            {
                Console.WriteLine(item);
            }
        }
    }
}

