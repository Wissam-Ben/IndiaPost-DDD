namespace Livraison.Tests.Model;
using Livraison.Model;
using Livraison.Model.ChauffeurAggregate;
using Livraison.Model.LotLivraisonAggregate;

public class AssignateurLivraisonTest
{
	[Fact]
	public void AssignerLotALivreurDoitEchouer()
	{
		AssignateurLivraison assignateurLivraison = new AssignateurLivraison();
		Chauffeur chauffeur = new Chauffeur("1", new CreneauTravail(10, 18));
		LotLivraison lotLivraison = new LotLivraison("1", "Île de France", new List<Colis>
		{
			new Colis("colis1", 1, new Adresse("242 Rue Faubourg Saint-Antoine", "île de France")),
			new Colis("colis1", 2, new Adresse("242 Rue Faubourg Saint-Antoine", "île de France")),
			new Colis("colis1", 3, new Adresse("242 Rue Faubourg Saint-Antoine", "île de France")),
			new Colis("colis1", 4, new Adresse("242 Rue Faubourg Saint-Antoine", "île de France")),
			new Colis("colis1", 5, new Adresse("242 Rue Faubourg Saint-Antoine", "île de France")),
			new Colis("colis1", 6, new Adresse("242 Rue Faubourg Saint-Antoine", "île de France")),
			new Colis("colis2", 7, new Adresse("242 Rue Faubourg Saint-Antoine", "île de France"))
		}, new HoraireLivraison(9, 12));

		Assert.Throws<PlageDeLivraisonNonDisponible>(() => assignateurLivraison.Assigner(chauffeur, lotLivraison));
	}
}
