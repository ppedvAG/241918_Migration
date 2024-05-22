namespace CarManager.Contracts
{
    public interface ICarService
    {
        IEnumerable<Car> GetCars();
        void CreateDemoAndSaveDemoData();
        void KillCar(Car car);
    }
}