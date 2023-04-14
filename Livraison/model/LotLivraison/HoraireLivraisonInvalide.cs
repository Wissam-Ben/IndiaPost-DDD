namespace Livraison.Model.LotLivraisonAggregate;

public class HoraireLivraisonInvalide : ArgumentOutOfRangeException
{
	public HoraireLivraisonInvalide(int max) : base($"La livraison ne doit pas dépasser {max} heures.")
	{

	}
}