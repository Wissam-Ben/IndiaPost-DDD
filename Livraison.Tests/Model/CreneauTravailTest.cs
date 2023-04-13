using Livraison.Model;

namespace Livraison.Tests.Model;

public class CreneauTravailTest
{
	[Fact]
	public void CreneauDoitEtreEntre6hEt21h()
	{
		Assert.Throws<SurexploitationDuChauffeur>(() => new CreneauTravail(0, 24));
	}
}