namespace Livraison.Usecase;

public class LotLivraisonNonTrouve : NullReferenceException
{
	public LotLivraisonNonTrouve() : base("Lot de livraison introuvable")
	{

	}
}