using FStore.Application.UserIdentity.DTOs.ManageAccountDTOs;

namespace FStore.Application.UserIdentity.Services.Interfaces
{
    public interface IAccountService
    {
        Task<ServiceResponse<Pagination<IEnumerable<AccountsResponseDto>>>> GetAccountsAsync(int pageNumber, int pageSize);
        Task<ServiceResponse<AccountDetailResponseDto>> GetAccountAsync(Guid accountId);
        Task<ServiceResponse<Pagination<IEnumerable<AccountsResponseDto>>>> SearchAccounts(string searchText, int pageNumber, int pageSize);
        Task<ServiceResponse<bool>> CreateAccount(CreateAccountDto newAccount);
        Task<ServiceResponse<bool>> UpdateAccount(Guid accountId, UpdateAccountDto updateAccount);
        Task<ServiceResponse<bool>> SoftDeleteAccount(Guid accountId);
    }
}
