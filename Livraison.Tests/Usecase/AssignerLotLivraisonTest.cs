namespace Livraison.Tests.Usecase;
using Livraison.Model;
using Livraison.Usecase;

public class AssignerLotLivraisonTest
{
	private LotLivraison _lot = new LotLivraison("Île de France", new List<Colis>
		{
			new Colis("colis1", 1, "242 Rue Faubourd Saint-Antoine"),
			new Colis("colis2", 5, "242 Rue FaubourdSaint-Antoine")
		}, new CreneauHoraire(8, 17));

	[Fact]
	public void assignerTest()
	{
		Chauffeurs chauffeurs = new FauxChauffeurs();
		Camions camions = new FauxCamions();

		AssignerLotLivraison assignement = new AssignerLotLivraison(camions, chauffeurs);
		Camion camionAssigne = assignement.assigner(_lot);

		Assert.False(camionAssigne.EstDisponible);
		Assert.NotNull(camionAssigne.Chauffeur);
		Assert.Equal(_lot.Secteur, camionAssigne.Secteur);
	}
}