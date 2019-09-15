using MagicBot.Model.Services;
using NUnit.Framework;

namespace MagicBot.Model.Tests.Services
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Execute_ReturnIsRight()
        {
            // Arrange
            ReplayMessageService service = new ReplayMessageService();
            string value = "Hello";
            string expected = value;
            string actual = string.Empty;

            // Act
            actual = service.Execute(value);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}