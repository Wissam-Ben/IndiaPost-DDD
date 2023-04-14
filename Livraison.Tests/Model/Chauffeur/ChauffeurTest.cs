namespace Livraison.Tests.Model;
using Livraison.Model.ChauffeurAggregate;

public class ChauffeurTest
{
	private Chauffeur _chauffeur = new Chauffeur("1", new CreneauTravail(10, 18));

	[Fact]
	public void AssignerLivraisonEchoueSiDejaAssigner()
	{
		_chauffeur.AssignerLivraison();
		Assert.Throws<ChauffeurDejaAssigne>(() => _chauffeur.AssignerLivraison());
	}

}