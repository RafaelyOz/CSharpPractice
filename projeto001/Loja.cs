class Loja{
    public string NomeLoja{get; set;}
    public string Localizacao{get;set;}
    public List<Funcionario> Funcionarios;
    public List<Cliente> Clientes;

    public Loja(string nomeLoja, string localizacao){
        NomeLoja = nomeLoja;
        Localizacao = localizacao;
    }
}