using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ConcertRepository: RepositoryBase<Concert>, IConcertRepository
    {
        public ConcertRepository(RepositoryContext repositoryContext): base(repositoryContext)
        {

        }

        public void CreateConcert(Concert concert)
        {
            Create(concert);    
        }

        public void DeleteConcert(Concert concert)
        {
            Delete(concert);
        }

        public async Task<IEnumerable<Concert>> GetAllConcertsAsync(bool trackChanges)
        {
            return await FindAll(trackChanges).OrderBy(c => c.Date).ToListAsync();
        }

        public async Task<IEnumerable<PartyConcert>> GetPartyConcertsAsync(bool trackChanges) 
        {
            return await _repositoryContext.PartyConcerts.Include(c => c.ConcertPlace).ToListAsync();
        }

        public async Task<Concert> GetConcertAsync(int concertId, bool trackChanges) 
        {
            return await FindByCondition(c => c.Id.Equals(concertId), trackChanges).SingleOrDefaultAsync();
        }
    }
}
