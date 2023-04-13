namespace Livraison.Usecase;

public class ChauffeurNonTrouve : NullReferenceException
{
	public ChauffeurNonTrouve() : base("Chauffeur non trouvé.")
	{

	}
}