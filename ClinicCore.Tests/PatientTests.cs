using Xunit;
using ClinicCore;
using System;


namespace ClinicCore.Tests
{
    public class PatientTests
    {
        [Fact]
        public void CalculateAge_ShouldReturnCorrectAge_WhenBirthdayPassed()
        {
            // Arrange
            var patient = new Patient
            {
                BirthDate = DateTime.Today.AddYears(-20)
            };

            // Act
            int age = patient.CalculateAge();

            // Assert
            Assert.Equal(20, age);
        }

        [Fact]
        public void CalculateAge_ShouldReturnOneYearLess_WhenBirthdayIsTomorrow()
        {
            // Arrange
            var patient = new Patient
            {
                BirthDate = DateTime.Today.AddYears(-20).AddDays(1)
            };

            // Act
            int result = patient.CalculateAge();

            // Assert
            Assert.Equal(19, result);
        }
    }
}