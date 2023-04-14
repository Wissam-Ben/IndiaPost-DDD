namespace Livraison.Model;

public interface Chauffeurs
{
	Chauffeur? TrouverParSecteur(string secteur);
	void Sauvegarder(Chauffeur chauffeur);
}