namespace Livraison.Model;

public interface Chauffeurs
{
	@string? TrouverParSecteur(string secteur);
	void Sauvegarder(@string chauffeur);
}