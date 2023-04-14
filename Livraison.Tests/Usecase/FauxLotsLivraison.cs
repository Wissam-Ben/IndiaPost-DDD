namespace Livraison.Tests.Usecase;
using Livraison.Model.LotLivraisonAggregate;

public class FauxLotsLivraison : LotsLivraison
{
	LotLivraison? LotsLivraison.FindById(string lotID)
	{
		return new LotLivraison(lotID, "Île de France", new List<Colis>
		{
			new Colis("colis1", 1, new Adresse("242 Rue Faubourg Saint-Antoine", "île de France")),
			new Colis("colis1", 2, new Adresse("242 Rue Faubourg Saint-Antoine", "île de France")),
			new Colis("colis1", 3, new Adresse("242 Rue Faubourg Saint-Antoine", "île de France")),
			new Colis("colis1", 4, new Adresse("242 Rue Faubourg Saint-Antoine", "île de France")),
			new Colis("colis1", 5, new Adresse("242 Rue Faubourg Saint-Antoine", "île de France")),
			new Colis("colis1", 6, new Adresse("242 Rue Faubourg Saint-Antoine", "île de France")),
			new Colis("colis2", 7, new Adresse("242 Rue Faubourg Saint-Antoine", "île de France"))
		}, new HoraireLivraison(11, 14));
	}
}