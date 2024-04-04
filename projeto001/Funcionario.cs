class Funcionario{
    public string NomeFuncionario{get; set;}
    public string Cpf_Funcionario{get; set;}

    public string Cargo{get; set;}
    public  int Salario{get; set;}

    public DateOnly DataAdmissao{get; set;}

    public Funcionario(string nomeFuncionario, string cpf_Funcionario, string cargo){
        NomeFuncionario = nomeFuncionario;
        Cpf_Funcionario = cpf_Funcionario;
        Cargo = cargo;
    }
}