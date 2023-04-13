namespace Livraison.Usecase;

public class CamionNonTrouve : ArgumentNullException
{
	public CamionNonTrouve() : base("Camion non trouvé.")
	{

	}
}