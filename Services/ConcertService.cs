using AutoMapper;
using Contracts;
using Entities.Models;
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

        public async Task<PartyConcertDto> CreatePartyConcertAsync(PartyConcertForCreationDto partyConcert)
        {
            var partyConcertEntity = _mapper.Map<PartyConcert>(partyConcert);

             _repositoryManager.Concert.CreateConcert(partyConcertEntity);

            await _repositoryManager.SaveAsync();

            var entityToReturn = _mapper.Map<PartyConcertDto>(partyConcertEntity);

            return entityToReturn;
            
        }

        public async Task<IEnumerable<PartyConcertDto>> GetPartyConcertsAsync(bool trackChanges)
        {
            var concerts = await _repositoryManager.Concert.GetPartyConcertsAsync(trackChanges);
            var concertsDto = _mapper.Map<IEnumerable<PartyConcertDto>>(concerts);
            return concertsDto;
        }

        public Task<IEnumerable<ClassicConcertDto>> GetClassicConcertsAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OpenAirConcertDto>> GetOpenAirConcertsAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<OpenAirConcertDto> CreateOpenAirConcertAsync(OpenAirConcertForCreationDto partyConcert)
        {
            throw new NotImplementedException();
        }

        public Task<ClassicConcertDto> CreateClassicConcertAsync(ClassicConcertForCreationDto partyConcert)
        {
            throw new NotImplementedException();
        }
    }
}