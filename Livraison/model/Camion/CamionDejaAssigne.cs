namespace Livraison.Model;

public class CamionDejaAssigne : ArgumentException
{
	public CamionDejaAssigne() : base("Le camion a déjà un chauffeur assigné.")
	{

	}
}