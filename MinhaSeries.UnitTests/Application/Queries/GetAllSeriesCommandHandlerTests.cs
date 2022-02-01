using MinhaSeries.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using MinhaSeries.Core.Enums;
using Moq;
using MinhaSeries.Core.Repositories;
using MinhaSeries.Application.Queries.GetAllSeriesQuery;
using System.Threading;

namespace MinhaSeries.UnitTests.Application.Queries
{
    public class GetAllSeriesCommandHandlerTests
    {
        [Fact] 
        public async Task ThreeSeriesExist_Executed_ReturnThreeSeriesViewModels()
        {
            // Arrange
            var series = new List<Serie>
            {
                new Serie("Expresso do amanhã", "muito foda", "2020", Genre.Action, true),
                new Serie("Ozark", "boa demais", "2020", Genre.Action, true),
                new Serie("The Witcher", "boa", "2020", Genre.Action, true)
            };

            var serieRepositoryMock = new Mock<ISerieRepository>();
            serieRepositoryMock.Setup(sr => sr.GetAllAsync().Result).Returns(series);

            var getAllSerieQuery = new GetAllSeriesQuery();
            var getAllSerieQueryHandler = new GetAllSeriesQueryHandler(serieRepositoryMock.Object);
            //Act

            var serieViewModelList = await getAllSerieQueryHandler.Handle(getAllSerieQuery, new CancellationToken());

            // Assert
            Assert.NotNull(serieViewModelList);
            Assert.NotEmpty(serieViewModelList);
            Assert.Equal(series.Count,serieViewModelList.Count);

            serieRepositoryMock.Verify(sr => sr.GetAllAsync().Result, Times.Once);
        }
       
    }
}
