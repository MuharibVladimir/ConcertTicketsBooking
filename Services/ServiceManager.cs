using AutoMapper;
using Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public sealed class ServiceManager: IServiceManager
    {
        private readonly Lazy<IConcertService> _concertService;

        public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper, ILoggerManager logger)
        {
            _concertService = new Lazy<IConcertService>(() => new ConcertService(repositoryManager, logger, mapper));
        }

        public IConcertService ConcertService => _concertService.Value;
    }
}
