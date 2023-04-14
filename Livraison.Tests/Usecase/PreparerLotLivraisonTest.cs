namespace Livraison.Tests.Usecase;
using Livraison.Model;
using Livraison.Model.LotLivraisonAggregate;

public class PreparerLotLivraisonTest
{

	private static string _secteur = "Île de France";

	[Fact]
	public void LotLivraisonDoitEtrePreparer()
	{
		Assert.True(true);
	}

	[Fact]
	public void LotLivraisonDoitAvoirAuMoins5Colis()
	{
		Assert.Throws<QuantiteColisInvalide>(() => new LotLivraison("1", _secteur, new List<Colis>
		{
			new Colis("colis1", 1, new Adresse("242 Rue Faubourg Saint-Antoine", _secteur)),
			new Colis("colis1", 2, new Adresse("242 Rue Faubourg Saint-Antoine", _secteur)),
			new Colis("colis1", 3, new Adresse("242 Rue Faubourg Saint-Antoine", _secteur)),
			new Colis("colis2", 4, new Adresse("242 Rue Faubourg Saint-Antoine", _secteur))
		}, new HoraireLivraison(10, 12)));
	}

	[Fact]
	public void TousLesColisDuLotDoiventEtreDansLeMemeSecteur()
	{

		Assert.Throws<ColisDansUnAutreSecteur>(() => new LotLivraison("1", _secteur, new List<Colis>
		{
			new Colis("colis1", 1, new Adresse("242 Rue Faubourg Saint-Antoine", _secteur)),
			new Colis("colis1", 2, new Adresse("242 Rue Faubourg Saint-Antoine", _secteur)),
			new Colis("colis1", 3, new Adresse("242 Rue Faubourg Saint-Antoine", _secteur)),
			new Colis("colis2", 4, new Adresse("242 Rue Faubourg Saint-Antoine", _secteur)),
			new Colis("colis3", 6, new Adresse("242 Rue Faubourg Saint-Antoine", "Normandie"))
		}, new HoraireLivraison(10, 12)));
	}

	[Fact]
	public void SecteurDuLotLivraisonEtColisDoiventEtreIdentiques()
	{
		var lot = new LotLivraison("1", _secteur, new List<Colis>
		{
			new Colis("colis1", 1, new Adresse("242 Rue Faubourg Saint-Antoine", _secteur)),
			new Colis("colis1", 2, new Adresse("242 Rue Faubourg Saint-Antoine", _secteur)),
			new Colis("colis1", 3, new Adresse("242 Rue Faubourg Saint-Antoine", _secteur)),
			new Colis("colis2", 4, new Adresse("242 Rue Faubourg Saint-Antoine", _secteur)),
			new Colis("colis3", 6, new Adresse("242 Rue Faubourg Saint-Antoine", _secteur))
		}, new HoraireLivraison(10, 12));

		Assert.Equal(lot.Secteur, lot.Colis[0].Adresse.Secteur);
	}
}