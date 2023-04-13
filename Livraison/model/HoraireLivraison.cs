namespace Livraison.Model;

public record HoraireLivraison
{
	private static readonly int DUREE_LIVRAISON_MAX = 3;
	public int Debut { get; init; }
	public int Fin { get; init; }

	public HoraireLivraison(int debut, int fin)
	{
		if (DUREE_LIVRAISON_MAX < Math.Abs(fin - debut))
		{
			throw new HoraireLivraisonInvalide(DUREE_LIVRAISON_MAX);
		}
		(Debut, Fin) = fin <= debut ? (fin, debut) : (debut, fin);
	}

	public int NombreHeures => Fin - Debut;
}