using Microsoft.EntityFrameworkCore;
using MinhaSeries.Core.Entities;
using MinhaSeries.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaSeries.Infrastructure.Persistence.Repositories
{
   
    public class SerieRepository : ISerieRepository
    {
        private readonly MinhaSeriesDbContext _dbContext;

        public SerieRepository(MinhaSeriesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Serie serie)
        {
            await _dbContext.Series.AddAsync(serie);
            await _dbContext.SaveChangesAsync();
        }

        public async Task AddCommentAsync(SerieComment serieComment)
        {
            await _dbContext.SeriesComments.AddAsync(serieComment);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Serie>> GetAllAsync()
        {
           return await _dbContext.Series.ToListAsync();
        }

        public async Task<Serie> GetByIdAsync(int id)
        {
            return await _dbContext.Series.SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
