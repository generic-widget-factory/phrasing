using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TechLibrary.Services;

namespace TechLibrary.Controllers.Tests
{
    [TestFixture()]
    [Category("ControllerTests")]
    public class AgencyControllerTests
    {

        private  Mock<ILogger<AgencyController>> _mockLogger;
        private  Mock<IAgencyService> _mockAgencyService;
        private Mock<IQueryService> _mockQueryService;
        private NullReferenceException _expectedException;

        [OneTimeSetUp]
        public void TestSetup()
        {
            _expectedException = new NullReferenceException("Test Failed...");
            _mockLogger = new Mock<ILogger<AgencyController>>();
            _mockQueryService = new Mock<IQueryService>();
            _mockAgencyService = new Mock<IAgencyService>();
        }

        [Test()]
        public async Task GetAllTest()
        {
            //  Arrange
            _mockAgencyService.Setup(b => b.GetAgenciesAsync()).Returns(Task.FromResult(It.IsAny<List<Domain.Agency>>()));
            var sut = new AgencyController(_mockLogger.Object, _mockAgencyService.Object, _mockQueryService.Object);

            //  Act
            var result = await sut.GetAll();

            //  Assert
            _mockAgencyService.Verify(s => s.GetAgenciesAsync(), Times.Once, "Expected GetAgenciesAsync to have been called once");
        }
    }
}