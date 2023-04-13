namespace Livraison.Model;

public record LotLivraison
{
	public string Secteur { get; init; }
	public List<Colis> Colis { get; init; }

	public CreneauHoraire PlageLivraison { get; init; }

	public LotLivraison(string secteur, List<Colis> colis, CreneauHoraire plageLivraison)
	{
		Secteur = secteur;
		Colis = colis;
		PlageLivraison = plageLivraison;
	}

	public static LotLivraison Vide(string secteur)
	{
		return new LotLivraison(secteur, new List<Colis>(), new CreneauHoraire(0, 0));
	}
}