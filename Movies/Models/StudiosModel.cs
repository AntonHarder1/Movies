namespace Movies.Models
{
    public class StudiosModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string HQCity { get; set; }
        public int NoOfEmployees { get; set; }

        public StudiosModel(int id, string name, string hQCity, int noOfEmployees)
        {
            Id = id;
            Name = name;
            HQCity = hQCity;
            NoOfEmployees = noOfEmployees;
        }
        public StudiosModel()
        {

        }
    }
}
