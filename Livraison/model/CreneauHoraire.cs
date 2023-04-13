namespace Livraison.Model;

public record CreneauHoraire
{
	public int Debut { get; init; }
	public int Fin { get; init; }

	public CreneauHoraire(int debut, int fin)
	{
		(Debut, Fin) = fin <= debut ? (fin, debut) : (debut, fin);
	}

	public int NombreHeures => Fin - Debut;
}