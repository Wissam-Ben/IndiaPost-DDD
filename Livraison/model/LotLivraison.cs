namespace Livraison.Model;

public record LotLivraison
{
	public string Secteur { get; init; }
	public List<Colis> Colis { get; init; }

	public HoraireLivraison Horaires { get; init; }

	public LotLivraison(string secteur, List<Colis> colis, HoraireLivraison plageLivraison)
	{
		Secteur = secteur;
		Colis = colis;
		Horaires = plageLivraison;
	}

	public static LotLivraison Vide(string secteur)
	{
		return new LotLivraison(secteur, new List<Colis>(), new HoraireLivraison(0, 0));
	}
}