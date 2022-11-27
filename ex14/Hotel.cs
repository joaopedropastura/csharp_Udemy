public class Hotel
{
	public string Nome {get;set;}
	public string Email {get;set;}
	public int Quarto {get;set;}

	public override string ToString()
	{
		return $"Nome: {this.Nome}\nEmail: {this.Email}\nQuarto: {this.Quarto}";
	}
}

