﻿using System.Globalization;

namespace CommonLibrary.Exceptions;
/// <summary>
/// Модель исключения, возникающего при отказе в доступе.
/// </summary>
public class ForbiddenException : Exception
{
    public ForbiddenException() : base() { }
    public ForbiddenException(string message) : base(message) { }
    public ForbiddenException(string message, Exception innerException) : base(message, innerException) { }

    public ForbiddenException(string message, params object[] args)
        : base(string.Format(CultureInfo.CurrentCulture, message, args)) { }
}
