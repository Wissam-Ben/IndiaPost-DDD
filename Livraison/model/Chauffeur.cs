namespace Livraison.Model;

public class Chauffeur
{
	public string ChauffeurID { get; init; }

	public bool EstDisponible { get; set; }

	public (int, int) PlageDisponibilite { get; init; }

	public Chauffeur(string chauffeurID, (int, int) plageDisponibilite)
	{
		(ChauffeurID, PlageDisponibilite) = (chauffeurID, plageDisponibilite);
	}

	public void AssignerLivraison(LotLivraison lotLivraison)
	{
		(int DebutService, int FinService) plage = PlageDisponibilite;
		if (lotLivraison.PlageLivraison.Debut < plage.DebutService || plage.FinService < lotLivraison.PlageLivraison.FinEstimee)
		{
			throw new PlageDeLivraisonNonDisponible("Plage de livraison non compatible avec celle du chauffeur.");
		}

		EstDisponible = false;
	}
}