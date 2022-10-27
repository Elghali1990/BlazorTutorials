namespace BlazorTutorials.Models
{
    public class Employe
    {
        public int Id { get; set; }=0;
        public string Name { get; set; }=String.Empty;
        public string Contry { get; set; }=String.Empty;    

        public string NameWithContry=>this.Name +"("+this.Contry+")";
    }
}
