namespace Livraison.Tests.Usecase;
using Livraison.Model.ChauffeurAggregate;

public class FauxChauffeurs : Chauffeurs
{
	Chauffeur? Chauffeurs.TrouverParSecteur(string secteur)
	{
		return new Chauffeur("1", new CreneauTravail(10, 18));
	}

	void Chauffeurs.Sauvegarder(Chauffeur chauffeur)
	{

	}
}