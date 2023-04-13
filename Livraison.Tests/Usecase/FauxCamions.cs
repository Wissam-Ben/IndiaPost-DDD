namespace Livraison.Tests.Usecase;
using Livraison.Model;

public class FauxCamions : Camions
{
	Camion? Camions.TrouverParSecteur(string secteur)
	{
		return new Camion("1", true, secteur);
	}

	void Camions.Sauvegarder(Camion camion)
	{

	}
}