namespace Etudiants.API.Models
{
    public class Etudiant
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public DateTime DateInscription { get; set; }
    }
}
