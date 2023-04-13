using Livraison.Model;

namespace Livraison.Tests.Model;

public class ChauffeurTest
{
	[Fact]
	public void AssignerLivraisonDoitEchouerSiPlageIncompatible()
	{
		var chauffeur = new Chauffeur("1", new CreneauTravail(10, 16));
		var lotLivraison = new LotLivraison("Ile de France", new List<Colis>(), new HoraireLivraison(8, 11));

		Assert.Throws<PlageDeLivraisonNonDisponible>(() => chauffeur.AssignerLivraison(lotLivraison));
	}
}