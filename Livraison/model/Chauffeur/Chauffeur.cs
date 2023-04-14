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

	public void AssignerLivraison()
	{
		EstDisponible = false;
	}

	private bool NePeutPasAccepterHoraireLivraison(HoraireLivraison horaire)
	{
		return horaire.Debut < HorairesTravail.Debut || HorairesTravail.Fin < horaire.Fin;
	}
}