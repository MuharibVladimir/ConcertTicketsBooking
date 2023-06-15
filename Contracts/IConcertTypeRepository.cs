using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IConcertTypeRepository
    {
        Task<IEnumerable<ConcertTypes>> GetAllConcertTypesAsync(bool trackChanges);
        Task<IEnumerable<OpenAir>> GetAllOpenAirConcertsAsync(bool trackChanges);
        Task<IEnumerable<Party>> GetAllPartyConcertsAsync(bool trackChanges);
        Task<IEnumerable<Classic>> GetAllClassicConcertsAsync(bool trackChanges);
        void CreatePartyConsert 

    }
}
