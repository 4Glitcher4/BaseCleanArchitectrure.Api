namespace BaseCleanArchitectrure.Core.Interfaces.RepositoryInterfaces
{
    public interface IBaseEntity
    {
        int Id { get; set; }
        DateTime CreateAt { get; set; }
        DateTime UpdateAt { get; set; }
    }
}
