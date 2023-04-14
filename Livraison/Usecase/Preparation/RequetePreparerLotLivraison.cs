public class RequetePreparerLotLivraison
{
	public List<ColisDto> Colis { get; set; }
	public string Secteur { get; set; }
	public int Debut { get; set; }
	public int Fin { get; set; }

	public RequetePreparerLotLivraison(List<ColisDto> colis, string secteur, int debut, int fin)
	{
		(Colis, Secteur, Debut, Fin) = (colis, secteur, debut, fin);
	}
}