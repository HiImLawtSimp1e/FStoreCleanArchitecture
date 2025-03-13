using Azure;
using FStore.Application.UserIdentity.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManageAccountController : ControllerBase
    {
        private readonly IAccountService _service;

        public ManageAccountController(IAccountService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetAccountsAsync(int pageNumber = 1, int pageSize = 10)
        {
            var response = await _service.GetAccountsAsync(pageNumber, pageSize);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAccountAsync(Guid id)
        {
            var response = await _service.GetAccountAsync(id);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
        [HttpGet("search")]
        public async Task<IActionResult> GetAccountsAsync(string searchText, int pageNumber = 1, int pageSize = 10)
        {
            var response = await _service.SearchAccounts(searchText, pageNumber, pageSize);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
    }
}
