using Livraison.Model;

namespace Livraison.Tests.Model;

public class ChauffeurTest
{
	[Fact]
	public void ChauffeurNeDoitPasTravaillerPlusDe8Heures()
	{
		var horaires = new CreneauHoraire(0, 24);
		Assert.Throws<SurexploitationDuChauffeur>(() => new Chauffeur("1", horaires));
	}

	[Fact]
	public void AssignerLivraisonDoitEchouerSiPlageIncompatible()
	{
		var chauffeur = new Chauffeur("1", new CreneauHoraire(10, 16));
		var lotLivraison = new LotLivraison("Ile de France", new List<Colis>(), new CreneauHoraire(8, 15));

		Assert.Throws<PlageDeLivraisonNonDisponible>(() => chauffeur.AssignerLivraison(lotLivraison));
	}
}