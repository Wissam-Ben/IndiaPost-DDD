namespace Livraison.Model;

public class LotLivraison
{
	public string Secteur { get; init; }
	public List<Colis> Colis { get; init; }

	public (int Debut, int FinEstimee) PlageLivraison { get; init; }

	public LotLivraison(string secteur, List<Colis> colis, (int, int) plageLivraison)
	{
		Secteur = secteur;
		Colis = colis;
		PlageLivraison = plageLivraison;
	}

	public static LotLivraison Vide(string secteur)
	{
		return new LotLivraison(secteur, new List<Colis>(), (0, 0));
	}
}