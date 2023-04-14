namespace Livraison.Model.ChauffeurAggregate;

public interface Chauffeurs
{
	Chauffeur? TrouverParSecteur(string secteur);
	void Sauvegarder(Chauffeur chauffeur);
}