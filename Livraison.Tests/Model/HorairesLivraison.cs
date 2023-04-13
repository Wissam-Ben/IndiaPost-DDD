using Livraison.Model;

namespace Livraison.Tests.Model;

public class HorairesLivraisonTest
{
	[Fact]
	public void HoraireTravailNeDoitPasDepasser3h()
	{
		Assert.Throws<HoraireLivraisonInvalide>(() => new HoraireLivraison(4, 8));
	}
}