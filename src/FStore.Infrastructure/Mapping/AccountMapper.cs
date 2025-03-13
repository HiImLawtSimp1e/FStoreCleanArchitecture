using FStore.Application.UserIdentity.DTOs.ManageAccountDTOs;

namespace FStore.Infrastructure.Mapping
{
    public class AccountMapper : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<Account, AccountsResponseDto>()
               .Map(dest => dest.Id, src => src.Id)
               .Map(dest => dest.Username, src => src.Username)
               .Map(dest => dest.IsActive, src => src.IsActive)
               .Map(dest => dest.Role, src => src.Role)
               .Map(dest => dest.CreatedAt, src => src.CreatedAt)
               .Map(dest => dest.CreatedBy, src => src.CreatedBy)
               .Map(dest => dest.ModifiedAt, src => src.ModifiedAt)
               .Map(dest => dest.ModifiedBy, src => src.ModifiedBy);

            config.NewConfig<Account, AccountDetailResponseDto>()
               .Map(dest => dest.Id, src => src.Id)
               .Map(dest => dest.Username, src => src.Username)
               .Map(dest => dest.IsActive, src => src.IsActive)
               .Map(dest => dest.Role, src => src.Role)
               .Map(dest => dest.Name, src => src.Addresses != null && src.Addresses.Any(a => a.IsMain) ? src.Addresses.FirstOrDefault(a => a.IsMain).Name : string.Empty)
               .Map(dest => dest.Email, src => src.Addresses != null && src.Addresses.Any(a => a.IsMain) ? src.Addresses.FirstOrDefault(a => a.IsMain).Email : string.Empty)
               .Map(dest => dest.PhoneNumber, src => src.Addresses != null && src.Addresses.Any(a => a.IsMain) ? src.Addresses.FirstOrDefault(a => a.IsMain).PhoneNumber : string.Empty)
               .Map(dest => dest.AddressLine, src => src.Addresses != null && src.Addresses.Any(a => a.IsMain) ? src.Addresses.FirstOrDefault(a => a.IsMain).AddressLine : string.Empty)
               .Map(dest => dest.CreatedAt, src => src.CreatedAt)
               .Map(dest => dest.CreatedBy, src => src.CreatedBy)
               .Map(dest => dest.ModifiedAt, src => src.ModifiedAt)
               .Map(dest => dest.ModifiedBy, src => src.ModifiedBy);
        }
    }
}
