using CarManager.Contracts;

namespace HalloBlazor.Data
{
    public class TestCarService : ICarService
    {
        public void CreateDemoAndSaveDemoData()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Car> GetCars()
        {
            yield return new Car() { Id = 1, Manufacturer = "Baudi", Model = "911", KW = 4 };
            yield return new Car() { Id = 2, Manufacturer = "Baudi", Model = "C Klasse", KW = 123 };
            yield return new Car() { Id = 3, Manufacturer = "Baudi", Model = "Trabant", KW = 900 };
        }

        public void KillCar(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
