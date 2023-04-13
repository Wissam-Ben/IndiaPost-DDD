namespace Livraison.Model;

public class Chauffeur
{
	private static readonly int TEMPS_TRAVAIL_MAX = 8;
	public string ChauffeurID { get; init; }

	public bool EstDisponible { get; set; }

	public CreneauTravail HorairesTravail { get; init; }

	public Chauffeur(string chauffeurID, CreneauTravail horairesTravail)
	{
		(ChauffeurID, HorairesTravail) = (chauffeurID, horairesTravail);
	}

	public void AssignerLivraison(LotLivraison lotLivraison)
	{
		if (lotLivraison.PlageLivraison.Debut < HorairesTravail.Debut ||
			HorairesTravail.Fin < lotLivraison.PlageLivraison.Fin)
		{
			throw new PlageDeLivraisonNonDisponible("Plage de livraison non compatible avec celle du chauffeur.");
		}

		EstDisponible = false;
	}
}