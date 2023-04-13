namespace Livraison.Model;

public class Chauffeur
{
	public string ChauffeurID { get; init; }

	public Chauffeur(string chauffeurID)
	{
		ChauffeurID = chauffeurID;
	}
}