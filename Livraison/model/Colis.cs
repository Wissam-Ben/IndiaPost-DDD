namespace Livraison.Model;

public class Colis
{
	public string ProduitID;
	public int Quantite;
	public string Adresse;

	public Colis(string produitID, int quantite, string adresse)
	{
		ProduitID = produitID;
		Quantite = quantite;
		Adresse = adresse;
	}

}