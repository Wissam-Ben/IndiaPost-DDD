namespace Livraison.Model;

public class HorairesTravailInvalides : ArgumentOutOfRangeException
{
	public HorairesTravailInvalides(int heureMin, int heureMax) : base($"Le créneau de travail doit être compris entre {heureMin}h et {heureMax}h inclus.")
	{
	}
}