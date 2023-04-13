namespace Livraison.Tests.Usecase;
using Livraison.Model;
using Livraison.Usecase;

public class AssignerLotLivraisonTest
{
	[Fact]
	public void Test1()
	{
		// except 1 to be true 
		Assert.True(true);
	}

	[Fact]
	public void assignerTest()
	{
		List<Colis> colis = new List<Colis>
		{
			new Colis("colis1", 1, "242 Rue Faubourd Saint-Antoine"),
			new Colis("colis2", 5, "242 Rue FaubourdSaint-Antoine")
		};
		LotLivraison lotLivraison = new LotLivraison("Île de France", colis);

		Chauffeurs chauffeurs = new FauxChauffeurs();
		Camions camions = new FauxCamions();

		AssignerLotLivraison assignement = new AssignerLotLivraison(camions, chauffeurs);
		Camion camionAssigne = assignement.assigner(lotLivraison);

		Assert.False(camionAssigne.EstDisponible);
		Assert.NotNull(camionAssigne.Chauffeur);
		Assert.Equal(lotLivraison.Secteur, camionAssigne.Secteur);
	}
}