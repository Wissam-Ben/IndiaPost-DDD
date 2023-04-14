namespace Livraison.Model.LotLivraisonAggregate;

public sealed class LotLivraison
{
	public string LotID { get; init; }
	public string Secteur { get; init; }
	public List<Colis> Colis { get; init; }
	public HoraireLivraison Horaires { get; init; }
	private static readonly int QUANTITE_COLIS_MIN = 5;

	public LotLivraison(string lotID, string secteur, List<Colis> colis, HoraireLivraison plageLivraison)
	{
		LotID = lotID;
		Secteur = secteur;
		QuantiteMinimaleColis(colis);
		ColisDansLeMemeSecteur(colis);
		Colis = colis;
		Horaires = plageLivraison;
	}

	public void AjouterColis(Colis colis)
	{
		ColisDansLeMemeSecteur(new List<Colis> { colis });
		Colis.Add(colis);
	}

	public static LotLivraison Nouveau(string secteur, List<Colis> colis, HoraireLivraison plageLivraison)
	{
		return new LotLivraison(Guid.NewGuid().ToString(), secteur, colis, plageLivraison);
	}

	private void ColisDansLeMemeSecteur(List<Colis> colis)
	{
		colis.ForEach(c =>
		{
			if (!String.Equals(c.Adresse.Secteur, Secteur))
			{
				throw new ColisDansUnAutreSecteur();
			}
		}
		);
	}

	private void QuantiteMinimaleColis(List<Colis> colis)
	{
		if (colis.Count < QUANTITE_COLIS_MIN)
		{
			throw new QuantiteColisInvalide();
		}
	}
}