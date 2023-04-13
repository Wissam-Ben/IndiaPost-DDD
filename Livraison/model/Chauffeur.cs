namespace Livraison.Model;

public class Chauffeur
{
	public string ChauffeurID { get; init; }

	public bool EstDisponible { get; set; }

	public CreneauTravail HorairesTravail { get; init; }

	public Chauffeur(string chauffeurID, CreneauTravail horairesTravail)
	{
		(ChauffeurID, HorairesTravail) = (chauffeurID, horairesTravail);
	}

	public void AssignerLivraison(LotLivraison lotLivraison)
	{
		if (NePeutPasAccepterHoraireLivraison(lotLivraison.Horaires))
		{
			throw new PlageDeLivraisonNonDisponible("Plage de livraison non compatible avec celle du chauffeur.");
		}

		EstDisponible = false;
	}

	private bool NePeutPasAccepterHoraireLivraison(HoraireLivraison horaire)
	{
		return horaire.Debut < HorairesTravail.Debut || HorairesTravail.Fin < horaire.Fin;
	}
}