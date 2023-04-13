namespace Livraison.Model;

public record HoraireLivraison
{
	private static readonly int DUREE_LIVRAISON_MAX = 3;
	public int Debut { get; init; }
	public int Fin { get; init; }

	public HoraireLivraison(int debut, int fin)
	{
		(Debut, Fin) = fin <= debut ? (fin, debut) : (debut, fin);

		if (DUREE_LIVRAISON_MAX < NombreHeures)
		{
			throw new HoraireLivraisonInvalide(DUREE_LIVRAISON_MAX);
		}
	}

	public int NombreHeures => Fin - Debut;
}