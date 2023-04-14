namespace Livraison.Tests.Usecase;
using Livraison.Model;

public class FauxChauffeurs : Chauffeurs
{
	@string? Chauffeurs.TrouverParSecteur(string secteur)
	{
		return new @string(secteur, new CreneauTravail(10, 18));
	}

	void Chauffeurs.Sauvegarder(@string chauffeur)
	{

	}
}