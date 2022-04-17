using System;
using Roofiy.Shared.Abstractions.Exceptions;

namespace Roofiy.Shared.Infrastructure.Exceptions;

public interface IExceptionCompositionRoot
{
    ExceptionResponse Map(Exception exception);
}