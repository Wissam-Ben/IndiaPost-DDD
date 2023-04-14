namespace Livraison.Model.CamionAggregate;

public interface Camions
{
	Camion? TrouverParSecteur(string secteur);
	void Sauvegarder(Camion camion);
}