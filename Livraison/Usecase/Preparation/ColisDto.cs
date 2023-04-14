public class ColisDto
{
	public string Secteur { get; set; }
	public string Ville { get; set; }
	public string ProduitID { get; set; }

	public int Quantite { get; set; }

	public ColisDto(string secteur, string ville, string produitID, int quantite)
	{
		(Secteur, Ville, ProduitID, Quantite) = (secteur, ville, produitID, quantite);
	}
}