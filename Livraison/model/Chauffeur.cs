namespace Livraison.Model;

public class Chauffeur
{
	private static readonly int TEMPS_TRAVAIL_MAX = 8;
	public string ChauffeurID { get; init; }

	public bool EstDisponible { get; set; }

	public CreneauHoraire PlageDisponibilite { get; init; }

	public Chauffeur(string chauffeurID, CreneauHoraire plageDisponibilite)
	{
		if (Chauffeur.TEMPS_TRAVAIL_MAX < plageDisponibilite.NombreHeures)
		{
			throw new SurexploitationDuChauffeur();
		}
		(ChauffeurID, PlageDisponibilite) = (chauffeurID, plageDisponibilite);
	}

	public void AssignerLivraison(LotLivraison lotLivraison)
	{
		if (lotLivraison.PlageLivraison.Debut < PlageDisponibilite.Debut ||
			PlageDisponibilite.Fin < lotLivraison.PlageLivraison.Fin)
		{
			throw new PlageDeLivraisonNonDisponible("Plage de livraison non compatible avec celle du chauffeur.");
		}

		EstDisponible = false;
	}
}