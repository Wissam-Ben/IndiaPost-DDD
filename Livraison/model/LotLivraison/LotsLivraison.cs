namespace Livraison.Model.LotLivraisonAggregate;

public interface LotsLivraison
{
	LotLivraison? FindById(string lotID);
	void Sauvegarder(LotLivraison lotLivraison);
}