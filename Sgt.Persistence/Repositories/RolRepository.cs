using MongoDB.Driver;
using Sgt.Application.Repository;
using Sgt.Domain.Entities;
using Sgt.Persistence.Generic;

namespace Sgt.Persistence.Repositories;

public class RolRepository : GenericRepository<RolEntity>, IRolRepository
{
    public RolRepository(IMongoDatabase database) : base(database)
    {
    }
}
