using Livraison.Model;

namespace Livraison.Tests.Model;

public class ChauffeurTest
{
	[Fact]
	public void AssignerLivraisonDoitEchouerSiPlageIncompatible()
	{
		var chauffeur = new Chauffeur("1", (10, 16));
		var lotLivraison = new LotLivraison("Ile de France", new List<Colis>(), (8, 15));

		Assert.Throws<PlageDeLivraisonNonDisponible>(() => chauffeur.AssignerLivraison(lotLivraison));
	}
}