using System;
using template_csharp_car_garage;
using Xunit;

namespace car_garage_tests
{
    public class CarTests
    {
        [Fact]
        public void SetMake_Should_Set_Make_of_Car()
        {
            // Arrange
            Car testCar = new Car();

            // Act
            testCar.SetMake("Ford");

            // Assert
            Assert.Equal("Ford", testCar.Make);
        }

        [Fact]
        public void SetModel_Should_Set_Model_of_Car()
        {
            // Arrange
            Car testCar = new Car();

            // Act
            testCar.SetModel("Taurus");

            // Assert
            Assert.Equal("Taurus", testCar.Model);
        }

        [Fact]
        public void SetFuel_Should_Set_Fuel_of_Car()
        {
            // Arrange
            Car testCar = new Car();

            // Act
            testCar.SetFuel(100);

            // Assert
            Assert.Equal(100, testCar.Fuel);
        }

        [Fact]
        public void SetAutoBrakeActive_Should_Set_AutoBrakeActive_of_Car()
        {
            // Arrange
            Car testCar = new Car();

            // Act
            testCar.SetAutoBrakeActive(true);

            // Assert
            Assert.True(testCar.AutoBrakeActive);
        }

        // ADD GETTER TESTS HERE
    }
}
