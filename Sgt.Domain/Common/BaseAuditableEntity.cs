using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace Sgt.Domain.Common;

public interface IBaseAuditableEntity
{
    public ObjectId Id { get; set; }
    public DateTime? RegisterDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public bool RegisterState { get; set; }
}
public class BaseAuditableEntity : IBaseAuditableEntity
{
    [BsonElement("_id")]
    [BsonRepresentation(BsonType.ObjectId)]
    [BsonId(IdGenerator = typeof(ObjectIdGenerator))]
    public ObjectId Id { get; set; }
    public DateTime? RegisterDate { get; set; } = (DateTime?)null;
    public DateTime? UpdateDate { get; set; } = (DateTime?)null;
    public bool RegisterState { get; set; }
}
