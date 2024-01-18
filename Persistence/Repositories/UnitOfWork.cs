using Abp.Domain.Uow;
using CleanArchitecture.Domain.Interfaces;
using CleanArchiteture.Persistence.Context;


namespace CleanArchiteture.Persistence.Repositories;

public class UnitOfWork: IUnitOfWork
{
    private readonly AppDbContext _context;
    public UnitOfWork(AppDbContext context) 
    {
        _context = context;
    }

    public async Task Commit(CancellationToken cancellationToken)
    {
        await _context.SaveChangesAsync(cancellationToken);
    }
}
