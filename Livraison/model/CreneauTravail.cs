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
		(Debut, Fin) = fin <= debut ? (fin, debut) : (debut, fin);

		if (CreneauTravail.TEMPS_TRAVAIL_MAX < NombreHeures)
		{
			throw new SurexploitationDuChauffeur();
		}

		if (Debut < CreneauTravail.HEURE_DEBUT_MIN || CreneauTravail.HEURE_FIN_MAX < Fin)
		{
			throw new HoraireTravailInvalide(CreneauTravail.HEURE_DEBUT_MIN, CreneauTravail.HEURE_FIN_MAX);
		}
	}

	public int NombreHeures => Fin - Debut;
}