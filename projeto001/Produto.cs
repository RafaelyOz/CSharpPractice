class Produto{
    public string NomeProduto{get; set;}
    public int Codigo{get; set;}
    public float Preco{get; set;}
    public int Quantidade{get; set;}
    public string Marca{get;set;}
    public string Categoria{get; set;}

    public Produto(string nomeProduto, int codigo, float preco, int quantidade, string marca, string categoria){
        
        NomeProduto = nomeProduto;
        Codigo = codigo;
        Preco = preco;
        Quantidade = quantidade;
        Marca = marca;
        Categoria = categoria;

    }

    public void ExibirDetalhes(){
        Console.WriteLine($"Nome do Produto: {NomeProduto}");
        Console.WriteLine($"Código do Produto: {Codigo}");
        Console.WriteLine($"Preço do Produto: {Preco}");
        Console.WriteLine($"Quantidade do Produto: {Quantidade}");
        Console.WriteLine($"Marca do Produto: {Marca}");
        Console.WriteLine($"Categoria do Produto: {Categoria}");
    }

    public void AtualizarQuantidadeEstoque(int novaQuantidade){
        Quantidade = novaQuantidade;
        Console.WriteLine($"Quantidade em estoque atualizada para : {Quantidade}");
    }

    public void AtualizarPreco(float novoPreco){
        Preco = novoPreco;
        Console.WriteLine($"Preço atualizado para: R${Preco}");
    }


}