using System.Globalization;

namespace CarrinhoDeCompras
{
    internal class Produto
    {
        private static int lastId = 0;

        public int Id { get; private set; }
        public string Descricao { get; private set; }
        public double Preco { get; private set; }
        public int Quantidade { get; set; }


        public Produto(string descricao, double preco, int quantidade)
        {
            Id = lastId++;
            Descricao = descricao;

            if (preco < 0) throw new ArgumentException("Preço não pode ser negativo.");
            Preco = preco;

            if (quantidade < 0) throw new ArgumentException("Quantidade não pode ser negativa.");
            Quantidade = quantidade;
        }

        public void AddQuant(int quant)
        {
            Quantidade = quant;
        }

        public void AlterarDescricao(string descricao)
        {
            Descricao = descricao;
        }

        
        public override string ToString()
        {
            double total = Preco * Quantidade;
            return $"Descrição: {Descricao}, Total: {total.ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
