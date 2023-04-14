namespace Livraison.Usecase;
using Livraison.Model;
public sealed class AssignerLotLivraison
{
	private Camions _camions;
	private Chauffeurs _chauffeurs;
	private LotsLivraison _lotsLivraison;

	public AssignerLotLivraison(Camions camions, Chauffeurs chauffeurs, LotsLivraison lotsLivraison)
	{
		(_camions, _chauffeurs, _lotsLivraison) = (camions, chauffeurs, lotsLivraison);
	}

	public Camion assigner(string lotID)
	{
		LotLivraison lotLivraison = _lotsLivraison.FindById(lotID)
			?? throw new LotLivraisonNonTrouve();

		Camion camion = _camions.TrouverParSecteur(lotLivraison.Secteur)
			?? throw new CamionNonTrouve();

		Chauffeur chauffeur = _chauffeurs.TrouverParSecteur(lotLivraison.Secteur)
		 ?? throw new ChauffeurNonTrouve();

		var assignateur = new AssignateurLivraison();
		assignateur.Assigner(chauffeur, lotLivraison);

		camion.AssignerChauffeur(chauffeur.ChauffeurID);
		camion.ChargerLot(lotLivraison.LotID);

		_chauffeurs.Sauvegarder(chauffeur);
		_camions.Sauvegarder(camion);
		return camion;
	}
}