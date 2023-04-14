namespace Livraison.Tests.Usecase;
using Livraison.Model.LotLivraisonAggregate;

public class FauxLotsLivraison : LotsLivraison
{
	private static string _secteur = "Île de France";

	LotLivraison? LotsLivraison.FindById(string lotID)
	{
		return new LotLivraison(lotID, _secteur, new List<Colis>
		{
			new Colis("colis1", 1, new Adresse("242 Rue Faubourg Saint-Antoine", _secteur)),
			new Colis("colis1", 2, new Adresse("242 Rue Faubourg Saint-Antoine", _secteur)),
			new Colis("colis1", 3, new Adresse("242 Rue Faubourg Saint-Antoine", _secteur)),
			new Colis("colis1", 4, new Adresse("242 Rue Faubourg Saint-Antoine", _secteur)),
			new Colis("colis1", 5, new Adresse("242 Rue Faubourg Saint-Antoine", _secteur)),
			new Colis("colis1", 6, new Adresse("242 Rue Faubourg Saint-Antoine", _secteur)),
			new Colis("colis2", 7, new Adresse("242 Rue Faubourg Saint-Antoine", _secteur))
		}, new HoraireLivraison(11, 14));
	}

	public void Sauvegarder(LotLivraison lotLivraison)
	{
		
	}
}