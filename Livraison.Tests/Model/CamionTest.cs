namespace Livraison.Tests.Model;
using Livraison.Model;

public class CamionTest
{
	private Camion _camion = new Camion("1", true, "Ile de France");

	[Fact]
	public void AssignerChauffeurEchoueSiDejaAssigne()
	{
		var chauffeurID1 = "1";
		var chauffeurID2 = "2";
		_camion.AssignerChauffeur(chauffeurID1);
		Assert.Throws<CamionDejaAssigne>(() => _camion.AssignerChauffeur(chauffeurID2));
	}
}