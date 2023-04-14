namespace Livraison.Model.ChauffeurAggregate;

public class Chauffeur
{
	public string ChauffeurID { get; init; }

	public bool EstDisponible { get; private set; }

	public CreneauTravail HorairesTravail { get; init; }

	public Chauffeur(string chauffeurID, CreneauTravail horairesTravail)
	{
		(ChauffeurID, HorairesTravail, EstDisponible) = (chauffeurID, horairesTravail, true);
	}

	public void AssignerLivraison()
	{
		if (EstDisponible == false)
		{
			throw new ChauffeurDejaAssigne();
		}
		EstDisponible = false;
	}
}