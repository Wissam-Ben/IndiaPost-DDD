namespace Livraison.Model;

public record CreneauTravail
{
	private static readonly int HEURE_DEBUT_MIN = 6;
	private static readonly int HEURE_FIN_MAX = 21;
	private static readonly int TEMPS_TRAVAIL_MAX = 8;
	public int Debut { get; init; }
	public int Fin { get; init; }

	public CreneauTravail(int debut, int fin)
	{
		if (CreneauTravail.TEMPS_TRAVAIL_MAX < Math.Abs(fin - debut))
		{
			throw new SurexploitationDuChauffeur();
		}

		(Debut, Fin) = fin <= debut ? (fin, debut) : (debut, fin);

		if (Debut < CreneauTravail.HEURE_DEBUT_MIN || CreneauTravail.HEURE_FIN_MAX < Fin)
		{
			throw new ArgumentOutOfRangeException("Le créneau de travail doit être compris entre 6h et 21h inclus.");
		}
	}
}