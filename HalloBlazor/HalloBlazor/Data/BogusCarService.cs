
using Bogus;

namespace HalloBlazor.Data
{
    public class BogusCarService : ICarService
    {
        Faker<Car> carFaker;
        int count = 0;

        public BogusCarService()
        {
            carFaker = new Faker<Car>();
            carFaker.RuleFor(x => x.Id, x=> count++);
            carFaker.RuleFor(x => x.Manufacturer, x => x.Vehicle.Manufacturer());
            carFaker.RuleFor(x => x.Model, x => x.Vehicle.Model());
            carFaker.RuleFor(x => x.KW, x => x.Random.Number(10, 500));
        }

        public IEnumerable<Car> GetCars()
        {
            return carFaker.Generate(100);
        }
    }
}
