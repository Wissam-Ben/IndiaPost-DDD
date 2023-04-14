namespace Livraison.Model.ChauffeurAggregate;

public class ChauffeurDejaAssigne : ArgumentException
{
	public ChauffeurDejaAssigne() : base("Le chauffeur a déjà un lot de livraison assigné.") { }
}