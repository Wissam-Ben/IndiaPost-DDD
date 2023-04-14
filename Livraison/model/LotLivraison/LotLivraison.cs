namespace Livraison.Model.LotLivraisonAggregate;

public sealed class LotLivraison
{
	public string LotID { get; init; }
	public string Secteur { get; init; }
	public List<Colis> Colis { get; init; }

	public HoraireLivraison Horaires { get; init; }

	public LotLivraison(string lotID, string secteur, List<Colis> colis, HoraireLivraison plageLivraison)
	{
		LotID = lotID;
		Secteur = secteur;
		Colis = colis;
		Horaires = plageLivraison;
	}
}