namespace Livraison.Model.LotLivraisonAggregate;

public class QuantiteColisInvalide : ArgumentException
{
	public QuantiteColisInvalide() : base("Il faut au minimum 5 colis par lot de livraison.")
	{

	}
}