using System;

namespace Roofiy.Shared.Abstractions.Exceptions;

public interface IExceptionToResponseMapper
{
    ExceptionResponse Map(Exception exception);
}