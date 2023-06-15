﻿using Contracts;
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

        public void CreateConcert(Party concert)
        {
            Create(concert);    
        }

        public void DeleteCompany(Concert concert)
        {
            Delete(concert);
        }

        public async Task<IEnumerable<Concert>> GetAllConcertsAsync(bool trackChanges)
        {
            return await FindAll(trackChanges).OrderBy(c => c.Date).ToListAsync();
        }

        public async Task<Concert> GetConcertAsync(Guid concertId, bool trackChanges)
        {
            return await FindByCondition(c => c.Id.Equals(concertId), trackChanges).SingleOrDefaultAsync();
        }
    }
}
