using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IConcertRepository
    {
        Task<IEnumerable<Concert>> GetAllConcertsAsync(bool trackChanges);
        Task<IEnumerable<PartyConcert>> GetPartyConcertsAsync(bool trackChanges);
        //Task<IEnumerable<T>> GetSpecificConcertsAsync<T>(bool trackChanges) where T : class;
        Task<Concert> GetConcertAsync(int concertId, bool trackChanges);
        void CreateConcert(Concert concert);
        void DeleteConcert(Concert concert);
    }
}
