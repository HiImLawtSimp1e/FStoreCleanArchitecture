namespace FStore.Domain.Abstractions
{
    public interface IEntity
    {
        public DateTime CreatedAt { get; set; } 
        public string CreatedBy { get; set; }
        public DateTime ModifiedAt { get; set; } 
        public string ModifiedBy { get; set; } 
    }
}
