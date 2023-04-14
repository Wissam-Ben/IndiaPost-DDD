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
			new Colis("colis1", 1, "242 Rue Faubourd Saint-Antoine"),
			new Colis("colis2", 5, "242 Rue FaubourdSaint-Antoine")
		}, new HoraireLivraison(9, 12));

		Assert.Throws<PlageDeLivraisonNonDisponible>(() => assignateurLivraison.Assigner(chauffeur, lotLivraison));
	}
}
