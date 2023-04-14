namespace Livraison.Tests.Usecase;
using Livraison.Model.LotLivraisonAggregate;
using Livraison.Usecase;

public class PreparerLotLivraisonTest
{

	private static string _secteur = "Île de France";

	[Fact]
	public void preparerTest()
	{
		List<Colis> colis = new List<Colis>
		{
			new Colis("colis1", 1, new Adresse("242 Rue Faubourg Saint-Antoine", _secteur)),
			new Colis("colis1", 2, new Adresse("242 Rue Faubourg Saint-Antoine", _secteur)),
			new Colis("colis1", 3, new Adresse("242 Rue Faubourg Saint-Antoine", _secteur)),
			new Colis("colis1", 4, new Adresse("242 Rue Faubourg Saint-Antoine", _secteur)),
			new Colis("colis1", 5, new Adresse("242 Rue Faubourg Saint-Antoine", _secteur)),
			new Colis("colis1", 6, new Adresse("242 Rue Faubourg Saint-Antoine", _secteur)),
			new Colis("colis2", 7, new Adresse("242 Rue Faubourg Saint-Antoine", _secteur))
		};

		LotsLivraison lotsLivraison = new FauxLotsLivraison();
		PreparerLotLivraison preparation = new PreparerLotLivraison(lotsLivraison);
		LotLivraison lot = preparation.Preparer(colis, _secteur, 10, 13);

		Assert.IsType<LotLivraison>(lot);
	}
}