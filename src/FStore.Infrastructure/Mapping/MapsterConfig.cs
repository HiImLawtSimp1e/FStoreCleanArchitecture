using System.Reflection;

namespace FStore.Infrastructure.Mapping
{
    public static class MapsterConfig
    {
        public static void Configure()
        {
            var config = TypeAdapterConfig.GlobalSettings;

            // Tự động đăng ký tất cả class implement IRegister
            config.Scan(Assembly.GetExecutingAssembly());
        }
    }
}
