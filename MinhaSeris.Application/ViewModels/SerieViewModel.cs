using MinhaSeries.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaSeries.Application.ViewModels
{
    public class SerieViewModel
    {
        public SerieViewModel(int id, string title, string description, string year, Genre genre, DateTime addedAt)
        {
            Id = id;
            Title = title;
            Description = description;
            Year = year;
            Genre = genre;
            AddedAt = addedAt;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Year { get; set; }
        public Genre Genre { get; set; }
        public DateTime AddedAt { get; set; }
    }
}
