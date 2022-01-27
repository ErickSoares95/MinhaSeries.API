using MinhaSeries.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaSeries.Core.Entities
{
    public class Serie : BaseEntity
    {
        public Serie(string title, string description, string year, Genre genre, bool active)
        {
            Title = title;
            Description = description;
            Year = year;
            Genre = genre;
            Active = active;

            AddedAt = DateTime.Now;
            Comments = new List<SerieComment>();
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Year { get; private set; }
        public Genre Genre { get; private set; }
        public bool Active { get; private set; }
        public DateTime AddedAt { get; private set; }
        public List<SerieComment> Comments { get; private set; }

        public void Update(string title, string description, string year, Genre genre)
        {
            Title = title;
            Description = description;
            Year = year;
            Genre = genre;
        }

        public void Delete()
        {
            if(Active == true)
            {
                Active = false;
            }
        }
    }
}
