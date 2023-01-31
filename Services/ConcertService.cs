using AutoMapper;
using Contracts;
using Services.Contracts;
using Shared;

namespace Services
{
    internal sealed class ConcertService : IConcertService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;

        public ConcertService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
            _repositoryManager = repositoryManager;
        }

        public async Task<IEnumerable<ConcertDto>> GetAllConcertsAsync(bool trackChanges)
        {
            var concerts = await _repositoryManager.Concert.GetAllConcertsAsync(trackChanges);
            var concertsDto = _mapper.Map<IEnumerable<ConcertDto>>(concerts);
            return concertsDto;
        }
    }
}