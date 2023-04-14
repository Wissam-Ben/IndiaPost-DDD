namespace Livraison.Tests.Usecase;
using Livraison.Model.LotLivraisonAggregate;

public class FauxLotsLivraison : LotsLivraison
{
	LotLivraison? LotsLivraison.FindById(string lotID)
	{
		return new LotLivraison(lotID, "Île de France", new List<Colis>
		{
			new Colis("colis1", 1, "242 Rue Faubourd Saint-Antoine"),
			new Colis("colis2", 5, "242 Rue FaubourdSaint-Antoine")
		}, new HoraireLivraison(11, 14));
	}
}