using FStore.Application.Common;
using FStore.Application.UserIdentity.DTOs.ManageAccountDTOs;
using FStore.Application.UserIdentity.Services.Interfaces;
using FStore.Domain.UserIdentity;

namespace FStore.Application.UserIdentity.Services.Implementations
{
    public class AccountService : IAccountService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AccountService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<ServiceResponse<Pagination<IEnumerable<AccountsResponseDto>>>> GetAccountsAsync(int pageNumber, int pageSize)
        {
            var accounts = await _unitOfWork.Account
                .GetAllAsync(a => !a.Deleted, pageNumber: pageNumber, pageSize: pageSize);

            var result = accounts.Adapt<IEnumerable<AccountsResponseDto>>();

            var pagingData = new Pagination<IEnumerable<AccountsResponseDto>>
            {
                Result = result,
                PageNumber = pageNumber,
                PageSize = pageSize
            };

            return new ServiceResponse<Pagination<IEnumerable<AccountsResponseDto>>>
            {
                Data = pagingData
            };
        }

        public async Task<ServiceResponse<AccountDetailResponseDto>> GetAccountAsync(Guid accountId)
        {
            var account = await _unitOfWork.Account
                .GetAsync(a => a.Id == accountId, filterInclude: a => a.Addresses.Where(address => address.IsMain));

            if (account == null) 
            {
                return new ServiceResponse<AccountDetailResponseDto>
                {
                    Success = false,
                    Message = "Account not found"
                };
            }

            var result = account.Adapt<AccountDetailResponseDto>();

            return new ServiceResponse<AccountDetailResponseDto>
            {
                Data = result
            };
        }

        public async Task<ServiceResponse<Pagination<IEnumerable<AccountsResponseDto>>>> SearchAccounts(string searchText, int pageNumber, int pageSize)
        {
            var accounts = await _unitOfWork.Account
              .GetAllAsync(a => 
              a.Username.ToLower().Contains(searchText.ToLower()) 
              && !a.Deleted, pageNumber: pageNumber, pageSize: pageSize);

            var result = accounts.Adapt<IEnumerable<AccountsResponseDto>>();

            var pagingData = new Pagination<IEnumerable<AccountsResponseDto>>
            {
                Result = result,
                PageNumber = pageNumber,
                PageSize = pageSize
            };

            return new ServiceResponse<Pagination<IEnumerable<AccountsResponseDto>>>
            {
                Data = pagingData
            };
        }

        public Task<ServiceResponse<bool>> CreateAccount(CreateAccountDto newAccount)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<bool>> UpdateAccount(Guid accountId, UpdateAccountDto updateAccount)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<bool>> SoftDeleteAccount(Guid accountId)
        {
            throw new NotImplementedException();
        }
    }
}
