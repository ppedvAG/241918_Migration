using CarManager.Contracts;
using HalloBlazor.Data;
using Moq;

namespace CarManager.Logic.Tests
{
    public class BogusCarServiceTests
    {
        [Fact]
        public void KillCar_do_delete_sucessfully()
        {
            var mock = new Mock<IRepository>();

            var cs = new BogusCarService(mock.Object);
            var carToKill = new Car() { KW = 5 };

            cs.KillCar(carToKill);

            mock.Verify(x => x.Delete(carToKill), Times.Once);
        }

        [Theory]
        [InlineData(200)]
        [InlineData(201)]
        [InlineData(1000)]
        [InlineData(5000)]
        public void KillCar_not_delete_because_too_much_KW(int kw)
        {
            var mock = new Mock<IRepository>();

            var cs = new BogusCarService(mock.Object);
            var carToKill = new Car() { KW = kw };

            Assert.Throws<ArgumentException>(() => cs.KillCar(carToKill));

            mock.Verify(x => x.Delete(carToKill), Times.Never);
        }

        [Fact]
        public void CreateDemoAndSaveDemoData_ShouldAdd100DemoCarsToRepository()
        {
            // Arrange
            var mockRepository = new Mock<IRepository>();
            var bogusCarService = new BogusCarService(mockRepository.Object);

            // Act
            bogusCarService.CreateDemoAndSaveDemoData();

            // Assert
            mockRepository.Verify(repo => repo.Add(It.IsAny<Car>()), Times.Exactly(100));
        }

        [Fact]
        public void KillCar_null_as_car_should_throw_ArgumentEx()
        {
            var cs = new BogusCarService(null);

            Assert.Throws<ArgumentNullException>(() => cs.KillCar(null!));
        }


    }
}