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

	public LotLivraison Preparer(List<Colis> colis, string secteur, int debut, int fin) 
	{
		LotLivraison lotLivraison = new LotLivraison("1", secteur, colis, new HoraireLivraison(debut, fin));
		_lotsLivraison.Sauvegarder(lotLivraison);
		return lotLivraison;
	}

}