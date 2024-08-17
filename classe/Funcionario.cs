using Biblioteca_III.Classe;

public class Funcionario : Pessoa
{
	private int Id {get;set;}
	
	private string? Cargo {get;set;}
	private DateTime DataAdmissao{get;set;}
	
	public Funcionario(int id,string cargo,DateTime dataAdmissao,string nome,DateTime dataNascimento
	+):base (nome,dataNascimento)
	{
			if(string.IsNullOrEmpty(cargo))
				throw new ArgumentException("Cargo não pode ser nulo ou vazio",nameof (cargo));
				
			if(dataAdmissao < DateTime.Now )
				throw new ArgumentException("Cargo não pode ser nulo ou vazio",nameof (dataAdmissao));
		
		Id=id;
		Cargo=cargo;
		DataAdmissao = dataAdmissao;
		}
    public override void ExibirInformacoes()
    {
        Console.WriteLine("Base exibiu")
    }
	
}

