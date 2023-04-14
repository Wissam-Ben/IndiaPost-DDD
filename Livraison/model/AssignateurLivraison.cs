namespace Livraison.Model;

public class AssignateurLivraison
{
	public void Assigner(Chauffeur chauffeur, LotLivraison lotLivraison)
	{
		if (ChauffeurNePeutPasAccepterHoraireLivraison(chauffeur, lotLivraison))
		{
			throw new PlageDeLivraisonNonDisponible("Plage de livraison non compatible avec celle du chauffeur.");
		}

		chauffeur.AssignerLivraison();
	}

	private bool ChauffeurNePeutPasAccepterHoraireLivraison(Chauffeur chauffeur, LotLivraison lotLivraison)
	{
		var horairesLivraison = lotLivraison.Horaires;
		var horairesTravail = chauffeur.HorairesTravail;

		return horairesLivraison.Debut < horairesTravail.Debut
			|| horairesTravail.Fin < horairesLivraison.Fin;
	}
}