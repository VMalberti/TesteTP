using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPListaGrid
{
    internal class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }

    internal class ProdutoModel
    {
        private static List<Produto> produtos = new List<Produto>();

        public void AdicionarProduto(Produto produto)
        {
            produtos.Add(produto);
        }

        public List<Produto> ListarProdutos()
        {
            return produtos;
        }
    }
    internal class ProdutoController
    {
        private ProdutoModel model = new ProdutoModel();

        public string SalvarProduto(string nome, string precoTexto)
        {
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(precoTexto))
                return "Nome e preço são obrigatórios.";

            if (!decimal.TryParse(precoTexto, out decimal preco))
                return "Preço inválido.";

            Produto produto = new Produto
            {
                Nome = nome,
                Preco = preco
            };

            model.AdicionarProduto(produto);
            return "Produto salvo com sucesso!";
        }

        public List<Produto> ObterProdutos()
        {
            return model.ListarProdutos();
        }
    }
}
