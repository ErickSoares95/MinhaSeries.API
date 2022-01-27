using MinhaSeries.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaSeries.Core.Repositories
{
    public interface ISerieRepository
    {
        Task<List<Serie>> GetAllAsync();
        Task<Serie> GetByIdAsync(int id);
        Task AddAsync(Serie serie);
        Task AddCommentAsync(SerieComment serieComment);
        Task SaveChangesAsync();
    }
}
