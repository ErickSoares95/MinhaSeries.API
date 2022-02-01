using MinhaSeries.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using MinhaSeries.Core.Enums;

namespace MinhaSeries.UnitTests.Core.Entities
{
    public class SerieTests
    {
        [Fact]
        public void TestIfSerieDelete()
        {
            var serie = new Serie("Homem que desafiou o diabo", "muito bom", "1995", Genre.Comedy, true);
            Assert.True(serie.Active);
            serie.Delete();
            Assert.False(serie.Active);
        }

        [Fact]
        public void TestIfSerieCreate()
        {
            var serie = new Serie("Homem que desafiou o diabo", "muito bom", "1995", Genre.Comedy, true);
            Assert.NotNull(serie.Title);
            Assert.NotEmpty(serie.Title);
            Assert.NotNull(serie.Description);
            Assert.NotEmpty(serie.Description);
            Assert.NotNull(serie.Year);
            Assert.NotEmpty(serie.Year);
            Assert.Equal(Genre.Comedy, serie.Genre);
            Assert.True(serie.Active);
        }
        [Fact]
        public void TestIfSerieUpdate()
        {
            var serie = new Serie("Homem que desafiou o diabo", "muito bom", "1995", Genre.Comedy, true);
            Assert.Equal("Homem que desafiou o diabo", serie.Title);
            Assert.Equal("muito bom", serie.Description);
            Assert.Equal("1995", serie.Year);
            Assert.Equal(Genre.Comedy, serie.Genre);
            
            serie.Update("Ozark", "bom demais", "2020", Genre.Action);

            Assert.NotEqual("Homem que desafiou o diabo", serie.Title);
            Assert.Equal("Ozark", serie.Title);
            Assert.NotEqual("muito bom", serie.Description);
            Assert.Equal("bom demais", serie.Description);
            Assert.NotEqual("1995", serie.Year);
            Assert.Equal("2020", serie.Year);
            Assert.NotEqual(Genre.Comedy, serie.Genre);
            Assert.Equal(Genre.Action, serie.Genre);
        }
    }
}
