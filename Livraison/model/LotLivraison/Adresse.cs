namespace Livraison.Model.LotLivraisonAggregate;

public class Adresse
{
	public string Ville { get; init; }
	public string Secteur { get; init; }

	public Adresse(string ville, string secteur)
	{
		Ville = ville;
		Secteur = secteur;
	}
}