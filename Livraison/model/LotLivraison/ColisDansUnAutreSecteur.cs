namespace Livraison.Model.LotLivraisonAggregate;

public class ColisDansUnAutreSecteur : ArgumentException
{
	public ColisDansUnAutreSecteur() : base("Un colis ne peut pas être livré dans un autre secteur que celui du lot de livraison.")
	{
	}
}