using MongoDB.Driver;
using Sgt.Application.Repository;
using Sgt.Domain.Entities;
using Sgt.Persistence.Generic;

namespace Sgt.Persistence.Repositories;

public class RequestRepository : GenericRepository<RequestEntity>, IRequestRepository
{
    public RequestRepository(IMongoDatabase database) : base(database)
    {
    }
}
