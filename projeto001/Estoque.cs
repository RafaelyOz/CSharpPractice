class Estoque{
    public List<Produto> produtos;

    public Estoque(){
        produtos = new List<Produto>();
    }

    public void AdcionarProduto(Produto produto){
        {
            produtos.Add(produto);
            Console.WriteLine($"Produto '{produto.NomeProduto}' adicionado ao estoque.");

        }
    }

    public void RemoverProduto(int codigo){

        Produto produto = BuscarPeloCodigo(codigo);
        if (produto != null)
        {
            produtos.Remove(produto);
            Console.WriteLine($"Produto '{produto.NomeProduto}' removido do estoque");
        }
        else{
            Console.WriteLine("Produto não encontrado no estoque");
        }
    }
    public Produto BuscarPeloCodigo(int codigo){
        foreach (Produto produto in produtos)
        {
            if (produto.Codigo == codigo)
            {
                return produto;
            }
        }
        return null;
    }
    public void ExibirListaProdutos(){
        Console.WriteLine("Produtos em estoque");
        foreach(Produto produto in produtos){
            Console.WriteLine($"Nome: {produto.NomeProduto}, Código {produto.Codigo}, preço: R${produto.Preco}, Quantidade: {produto.Quantidade}");
        }

    }
    
}