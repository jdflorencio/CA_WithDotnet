using CleanArchitecture.Domain.Entities;
using CleanArchiteture.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using CleanArchitecture.Domain.Interfaces;


namespace CleanArchiteture.Persistence.Repositories
{
    public class UserRepository: BaseRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context) { }

        public async Task<User> GetByEmail(string email, CancellationToken cancellationToken) {
            return await Context.Users.FirstOrDefaultAsync(x => x.Email == email, cancellationToken);
        }
    }
}
