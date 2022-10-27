using BlazorTutorials.Models;

namespace BlazorTutorials.Services
{
    public class EmployeService
    {
        public List<Employe> GetEmployes()
        {
            var employes = new List<Employe>();
            employes.Add(new Employe() { Name = "name 1", Contry = "contry 1" });
            employes.Add(new Employe() { Name = "name 2", Contry = "contry 2" });
            employes.Add(new Employe() { Name = "name 3", Contry = "contry 3" });
            employes.Add(new Employe() { Name = "name 4", Contry = "contry 4" });
            employes.Add(new Employe() { Name = "name 5", Contry = "contry 5" });
            return employes;
        }
    }
}
