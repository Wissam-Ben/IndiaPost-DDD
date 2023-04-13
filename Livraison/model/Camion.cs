namespace Livraison.Model;

public class Camion
{
	public string CamionID;
	public bool EstDisponible;
	public string Secteur;
	public Chauffeur? Chauffeur;

	public LotLivraison LotLivraison { get; private set; }

	public Camion(string camionId, bool estDisponible, string secteur)
	{
		CamionID = camionId;
		EstDisponible = estDisponible;
		Secteur = secteur;
		LotLivraison = LotLivraison.Vide(secteur);
	}

	public void AssignerChauffeur(Chauffeur chauffeur)
	{
		EstDisponible = false;
		Chauffeur = chauffeur;
	}

	public void ChargerLot(LotLivraison lotLivraison)
	{
		LotLivraison = lotLivraison;
	}
}