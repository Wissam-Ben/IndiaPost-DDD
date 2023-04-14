using Livraison.Model.CamionAggregate;
using Livraison.Model.LotLivraisonAggregate;

namespace Livraison.Usecase;

public sealed class PreparerLotLivraison
{
	private LotsLivraison _lotsLivraison;

	public PreparerLotLivraison(LotsLivraison lotsLivraison)
	{
		_lotsLivraison = lotsLivraison;
	}

	public LotLivraison Preparer(CreerLotLivraisonDto dto)
	{
		List<Colis> colis = dto.Colis.Select(c =>
		{
			return new Colis(
				c.ProduitID,
				c.Quantite,
				new Adresse(
					c.Ville,
					c.Secteur));
		}).ToList<Colis>();

		LotLivraison lotLivraison = new LotLivraison(
			"1",
			dto.Secteur,
			colis,
			new HoraireLivraison(
				dto.Debut,
				dto.Fin));

		_lotsLivraison.Sauvegarder(lotLivraison);
		return lotLivraison;
	}

}