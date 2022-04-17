using System.Net;

namespace Roofiy.Shared.Abstractions.Exceptions;

public record ExceptionResponse(object Response, HttpStatusCode StatusCode);