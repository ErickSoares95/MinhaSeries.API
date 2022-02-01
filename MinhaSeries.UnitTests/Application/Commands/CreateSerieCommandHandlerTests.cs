using MinhaSeries.Application.Commands.CreateSerie;
using MinhaSeries.Core.Entities;
using MinhaSeries.Core.Repositories;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace MinhaSeries.UnitTests.Application.Commands
{
    public class CreateSerieCommandHandlerTests
    {
        [Fact]
        public async Task InputDataIsOk_Executed_ReturnSerieId()
        {
            //Arrange
            var serieRepositoryMock = new Mock<ISerieRepository>();

            var createSerieCommand = new CreateSerieCommand
            {
                Title = "Ozark",
                Description = "Bom demais",
                Year = "2020",
                Active = true             
            };

            var createSerieCommandHandler = new CreateSerieCommandHandler(serieRepositoryMock.Object);


            //Act

            var id = await createSerieCommandHandler.Handle(createSerieCommand, new CancellationToken());

            //Assert
            Assert.True(id >= 0);

            serieRepositoryMock.Verify(sr => sr.AddAsync(It.IsAny<Serie>()), Times.Once);
        }
    }
}
