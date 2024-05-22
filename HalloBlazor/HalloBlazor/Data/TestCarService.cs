namespace HalloBlazor.Data
{
    public class TestCarService : ICarService
    {
        public IEnumerable<Car> GetCars()
        {
            yield return new Car() { Id = 1, Manufacturer = "Baudi", Model = "911", KW = 4 };
            yield return new Car() { Id = 2, Manufacturer = "Baudi", Model = "C Klasse", KW = 123 };
            yield return new Car() { Id = 3, Manufacturer = "Baudi", Model = "Trabant", KW = 900 };
        }
    }
}
