using Microsoft.Build.Framework;

namespace Unitiofworkfred.Models
{
    public class EnfantsModel
    {
       
        
        private string _nom;
        
        private string _prenom;

        private int _age;
       
      
       
        public string Nom { get => _nom; set => _nom = value; }
     
        public string Prenom { get => _prenom; set => _prenom = value; }
        
        public int Age { get => _age; set => _age = value; }
    }
}
