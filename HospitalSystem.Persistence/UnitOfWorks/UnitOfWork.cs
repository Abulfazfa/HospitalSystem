using HospitalSystem.Application.Interfaces.Repositories;
using HospitalSystem.Application.Interfaces.UnitOfWorks;
using HospitalSystem.Persistence.Context;
using HospitalSystem.Persistence.Repositories;

namespace HospitalSystem.Persistence.UnitOfWorks;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _dbContext;

    public UnitOfWork(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async ValueTask DisposeAsync() => await _dbContext.DisposeAsync();

    public int Save() => _dbContext.SaveChanges();
    public async Task<int> SaveAsync() => await _dbContext.SaveChangesAsync();
    IReadRepository<T> IUnitOfWork.GetReadRepository<T>() => new ReadRepository<T>(_dbContext);
    IWriteRepository<T> IUnitOfWork.GetWriteRepository<T>() => new WriteRepository<T>(_dbContext);
}