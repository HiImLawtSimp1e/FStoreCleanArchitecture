namespace FStore.Infrastructure.Persistence.Repositories
{
    public class AccountRepository : Repository<Account>, IAccountRepository
    {
        private readonly ApplicationDbContext _context;

        public AccountRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public void Update(Account entity)
        {
            _context.Accounts.Update(entity);
        }
    }
}
