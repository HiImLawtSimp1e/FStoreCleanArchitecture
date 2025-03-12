namespace FStore.Application.Common
{
    public class Pagination<T>
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public T? Result { get; set; }
    }
}
