namespace Livraison.Model.CamionAggregate;

public class CamionDejaAssigne : ArgumentException
{
	public CamionDejaAssigne() : base("Le camion a déjà un chauffeur assigné.")
	{

	}
}