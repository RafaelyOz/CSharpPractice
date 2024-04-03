class Cliente
{
    public string NomeCliente { get; set; }
    public string CPF { get; set; }
    public string Endereco { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }

    public Cliente(string nomeCliente, string cpf, string telefone, string email)
    {
        NomeCliente = nomeCliente;
        CPF = cpf;
        Telefone = telefone;
        Email = email;
    }
}
