using System.Security.Cryptography.X509Certificates;

public abstract class Pessoa() : IPessoa
{
	void ExibirInformações()
	{}
		public string nome { get; set; }
		public DateTime DataNascimento { get; set; }
		
		protected Pessoa (string nome ,DateTime dataNascimento)
		{
			if(string.IsNullOrEmpty(nome))
				throw new ArgumentException("Nome não pode ser nulo ou vazio",nameof (nome));
				
			nome = nome;
			DataNascimento = dataNascimento;
		}
		
	
}