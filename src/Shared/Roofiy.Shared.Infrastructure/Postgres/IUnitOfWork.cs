using System;
using System.Threading.Tasks;

namespace Roofiy.Shared.Infrastructure.Postgres;

public interface IUnitOfWork
{
    Task ExecuteAsync(Func<Task> action);
}