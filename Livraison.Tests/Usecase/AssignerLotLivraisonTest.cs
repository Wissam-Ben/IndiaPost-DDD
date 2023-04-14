namespace Livraison.Tests.Usecase;
using Livraison.Model.CamionAggregate;
using Livraison.Model.ChauffeurAggregate;
using Livraison.Model.LotLivraisonAggregate;
using Livraison.Usecase;

public class AssignerLotLivraisonTest
{
	private LotLivraison _lot = new LotLivraison("1", "Île de France", new List<Colis>
		{
			new Colis("colis1", 1, new Adresse("242 Rue Faubourg Saint-Antoine", "île de France")),
			new Colis("colis1", 2, new Adresse("242 Rue Faubourg Saint-Antoine", "île de France")),
			new Colis("colis1", 3, new Adresse("242 Rue Faubourg Saint-Antoine", "île de France")),
			new Colis("colis1", 4, new Adresse("242 Rue Faubourg Saint-Antoine", "île de France")),
			new Colis("colis1", 5, new Adresse("242 Rue Faubourg Saint-Antoine", "île de France")),
			new Colis("colis1", 6, new Adresse("242 Rue Faubourg Saint-Antoine", "île de France")),
			new Colis("colis2", 7, new Adresse("242 Rue Faubourg Saint-Antoine", "île de France"))
		}, new HoraireLivraison(11, 14));

	[Fact]
	public void assignerTest()
	{
		Chauffeurs chauffeurs = new FauxChauffeurs();
		Camions camions = new FauxCamions();
		LotsLivraison lotsLivraison = new FauxLotsLivraison();

		AssignerLotLivraison assignement = new AssignerLotLivraison(camions, chauffeurs, lotsLivraison);
		Camion camionAssigne = assignement.assigner(_lot.LotID);

		Assert.False(camionAssigne.EstDisponible);
		Assert.NotNull(camionAssigne.ChauffeurID);
		Assert.Equal(_lot.Secteur, camionAssigne.Secteur);
		Assert.Equal(_lot.LotID, camionAssigne.LotID);
	}
}