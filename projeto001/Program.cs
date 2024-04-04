static void Main(string[] args)
    {
      
        Produto meuProduto = new Produto("Celular", 12345, 1500, 10, "MarcaX", "Eletrônicos");
        meuProduto.NomeProduto = "Celular";
        meuProduto.Codigo = 12345;
        meuProduto.Preco = 1500;
        meuProduto.Quantidade = 10;
        meuProduto.Marca = "MarcaX";
        meuProduto.Categoria = "Eletrônicos";

        
        meuProduto.ExibirDetalhes();

        meuProduto.AtualizarQuantidadeEstoque(5);

        meuProduto.AtualizarPreco(899);
    }
