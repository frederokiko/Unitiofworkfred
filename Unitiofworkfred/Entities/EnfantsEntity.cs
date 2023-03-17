namespace Unitiofworkfred.Entities
{
    public class EnfantsEntity
    {
       private int _id;
        private string _nom;
        private string _prenom;
        private int _age;

         public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public int Age { get => _age; set => _age = value; }
       
    }
}
