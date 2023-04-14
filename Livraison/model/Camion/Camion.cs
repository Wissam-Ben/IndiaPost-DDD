namespace Livraison.Model;

public class Camion
{
	public string CamionID { get; init; }
	public bool EstDisponible { get; private set; }
	public string Secteur { get; private set; }
	public string? ChauffeurID { get; private set; }
	public string? LotID { get; private set; }

	public Camion(string camionId, bool estDisponible, string secteur)
	{
		CamionID = camionId;
		EstDisponible = estDisponible;
		Secteur = secteur;
		LotID = null;
	}

	public void AssignerChauffeur(string chauffeurID)
	{
		if (ChauffeurID is not null)
		{
			throw new CamionDejaAssigne();
		}

		EstDisponible = false;
		ChauffeurID = chauffeurID;
	}

	public void ChargerLot(string lotID)
	{
		LotID = lotID;
	}
}