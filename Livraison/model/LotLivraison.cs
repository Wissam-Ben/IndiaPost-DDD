namespace Livraison.Model;

public class LotLivraison
{
	public string Secteur;
	public List<Colis> Colis;

	public LotLivraison(string secteur, List<Colis> colis)
	{
		Secteur = secteur;
		Colis = colis;
	}

	public static LotLivraison Vide(string secteur)
	{
		return new LotLivraison(secteur, new List<Colis>());
	}
}