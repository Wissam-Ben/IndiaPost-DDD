namespace Livraison.Tests.Model;
using Livraison.Model.LotLivraisonAggregate;
using Livraison.Model.CamionAggregate;

public class HorairesLivraisonTest
{
	[Fact]
	public void HoraireTravailNeDoitPasDepasser3h()
	{
		Assert.Throws<HoraireLivraisonInvalide>(() => new HoraireLivraison(4, 8));
	}
}