using Movies.Models;

namespace Movies.MockData
{
    public class MockStudios
    {
        new List<StudiosModel> studiosList = new List<StudiosModel>()
        {
            new StudiosModel() {Id = 1, Name = "HollyWood", HQCity = "HollyWood", NoOfEmployees = 69},
            new StudiosModel() {Id = 2, Name = "BollyWood", HQCity = "BollyWood", NoOfEmployees = 42},
            new StudiosModel() {Id = 3, Name = "NollyWood", HQCity = "NollyWood", NoOfEmployees = 420}
        };
    }
}
