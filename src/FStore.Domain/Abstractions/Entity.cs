namespace FStore.Domain.Abstractions
{
    public abstract class Entity<T> 
    {
        public T Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime ModifiedAt { get; set; } = DateTime.Now;
        public string ModifiedBy { get; set; } = string.Empty;
    }
}
