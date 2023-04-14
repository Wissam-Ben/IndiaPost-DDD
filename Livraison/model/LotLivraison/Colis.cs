namespace Livraison.Model.LotLivraisonAggregate;

public record Colis
{
	public string ProduitID { get; init; }
	public int Quantite { get; init; }
	public Adresse Adresse { get; init; }

	public Colis(string produitID, int quantite, Adresse adresse)
	{
		ProduitID = produitID;
		Quantite = quantite;
		Adresse = adresse;
	}
}