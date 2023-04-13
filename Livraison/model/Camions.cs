namespace Livraison.Model;

public interface Camions
{

    Camion? TrouverParSecteur(string secteur);
    void Sauvegarder(Camion camion);
}