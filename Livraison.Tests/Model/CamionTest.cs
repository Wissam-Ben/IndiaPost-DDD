namespace Livraison.Tests.Model;
using Livraison.Model;

public class CamionTest
{
	private Camion _camion = new Camion("1", true, "Ile de France");

	[Fact]
	public void AssignerChauffeurEchoueSiDejaAssigne()
	{
		_camion.AssignerChauffeur(new Chauffeur("1", (9, 18)));
		Assert.Throws<CamionDejaAssigne>(() => _camion.AssignerChauffeur(new Chauffeur("2", (9, 19))));
	}
}