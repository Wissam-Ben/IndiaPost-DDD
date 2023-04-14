namespace Livraison.Usecase;
using Livraison.Model;
public sealed class AssignerLotLivraison
{
	private Camions _camions;
	private Chauffeurs _chauffeurs;

	public AssignerLotLivraison(Camions camions, Chauffeurs chauffeurs)
	{
		(_camions, _chauffeurs) = (camions, chauffeurs);
	}

	public Camion assigner(LotLivraison lotLivraison)
	{
		Camion camion = _camions.TrouverParSecteur(lotLivraison.Secteur)
			?? throw new CamionNonTrouve();

		Chauffeur chauffeur = _chauffeurs.TrouverParSecteur(lotLivraison.Secteur)
		 ?? throw new ChauffeurNonTrouve();

		chauffeur.AssignerLivraison(lotLivraison);
		camion.AssignerChauffeur(chauffeur.ChauffeurID);
		camion.ChargerLot(lotLivraison.LotID);

		_chauffeurs.Sauvegarder(chauffeur);
		_camions.Sauvegarder(camion);
		return camion;
	}
}