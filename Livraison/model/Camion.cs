namespace Livraison.Model;

public class Camion
{
	public string CamionID { get; init; }
	public bool EstDisponible { get; private set; }
	public string Secteur { get; private set; }
	public string? ChauffeurID { get; private set; }
	public LotLivraison LotLivraison { get; private set; }

	public Camion(string camionId, bool estDisponible, string secteur)
	{
		CamionID = camionId;
		EstDisponible = estDisponible;
		Secteur = secteur;
		LotLivraison = LotLivraison.Vide(secteur);
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

	public void ChargerLot(LotLivraison lotLivraison)
	{
		LotLivraison = lotLivraison;
	}
}