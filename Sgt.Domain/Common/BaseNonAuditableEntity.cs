using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.IdGenerators;

namespace Sgt.Domain.Common;

public interface IBaseNonAuditableEntity {
    public ObjectId Id { get; set; }
    public bool RegisterState { get; set; }
}
public class BaseNonAuditableEntity : IBaseNonAuditableEntity
{
    [BsonElement("_id")]
    [BsonRepresentation(BsonType.ObjectId)]
    [BsonId(IdGenerator = typeof(ObjectIdGenerator))]
    public ObjectId Id { get; set; }
    public bool RegisterState { get; set; }
}
