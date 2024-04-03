class Produto{
    public string NomeProduto{get; set;}
    public int Codigo{get; set;}
    public float Preco{get; set;}
    public int Quantidade{get; set;}
    public string Marca{get;set;}
    public string Categoria{get; set;}

    public Produto(string NomeProduto, int codigo, float preco, int quantidade){
        
        NomeProduto = NomeProduto;
        Codigo = codigo;
        Preco = preco;
        Quantidade = quantidade;

    }

}