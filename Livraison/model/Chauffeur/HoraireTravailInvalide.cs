namespace Livraison.Model.ChauffeurAggregate;

public class HoraireTravailInvalide : ArgumentOutOfRangeException
{
	public HoraireTravailInvalide(int heureMin, int heureMax) : base($"Le créneau de travail doit être compris entre {heureMin}h et {heureMax}h inclus.")
	{
	}
}