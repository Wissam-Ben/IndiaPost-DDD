namespace Livraison.Tests.Usecase;
using Livraison.Model;

public class FauxChauffeurs : Chauffeurs
{
	Chauffeur? Chauffeurs.TrouverParSecteur(string secteur)
	{
		return new Chauffeur(secteur, new CreneauTravail(10, 18));
	}

	void Chauffeurs.Sauvegarder(Chauffeur chauffeur)
	{

	}
}