namespace Livraison.Tests.Usecase;
using Livraison.Model.LotLivraisonAggregate;
using Livraison.Usecase;

public class PreparerLotLivraisonTest
{

	private static string _secteur = "Île de France";

	[Fact]
	public void preparerTest()
	{
		var colis = new List<ColisDto>
		{
			new ColisDto(_secteur, "242 Rue Faubourg Saint-Antoine", "colis1", 1),
			new ColisDto(_secteur, "242 Rue Faubourg Saint-Antoine", "colis1", 2),
			new ColisDto(_secteur, "242 Rue Faubourg Saint-Antoine", "colis1", 3),
			new ColisDto(_secteur, "242 Rue Faubourg Saint-Antoine", "colis1", 4),
			new ColisDto(_secteur, "242 Rue Faubourg Saint-Antoine", "colis1", 5),
			new ColisDto(_secteur, "242 Rue Faubourg Saint-Antoine", "colis1", 6),
			new ColisDto(_secteur, "242 Rue Faubourg Saint-Antoine", "colis2", 7)
		};
		var dto = new RequetePreparerLotLivraison(colis, _secteur, 10, 13);
		LotsLivraison lotsLivraison = new FauxLotsLivraison();
		PreparerLotLivraison preparation = new PreparerLotLivraison(lotsLivraison);
		LotLivraison lot = preparation.Preparer(dto);

		Assert.IsType<LotLivraison>(lot);
	}
}