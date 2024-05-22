using Bogus;
using HalloBlazor.Contracts;

namespace HalloBlazor.Data
{
    public class BogusCarService : ICarService
    {
        private readonly IRepository repository;

        Faker<Car> carFaker;
        int count = 0;

        public BogusCarService(IRepository repository)
        {
            carFaker = new Faker<Car>();
            //carFaker.RuleFor(x => x.Id, x => count++);
            carFaker.RuleFor(x => x.Manufacturer, x => x.Vehicle.Manufacturer());
            carFaker.RuleFor(x => x.Model, x => x.Vehicle.Model());
            carFaker.RuleFor(x => x.KW, x => x.Random.Number(10, 500));
            this.repository = repository;
        }

        public void KillCar(Car car)
        {
            if (car.KW > 200)
                throw new ArgumentException("Ist zu wertvoll!!");

            repository.Delete(car);   
        }

        public IEnumerable<Car> GetCars()
        {
            return repository.GetAll<Car>();
        }

        public void CreateDemoAndSaveDemoData()
        {
            foreach (var car in GetDemoCars())
            {
                repository.Add(car);
            }
        }

        private IEnumerable<Car> GetDemoCars()
        {
            return carFaker.Generate(100);
        }
    }

}
