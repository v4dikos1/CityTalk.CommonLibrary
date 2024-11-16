using System.Globalization;

namespace CommonLibrary.Exceptions;
/// <summary>
/// Модель исключения, возникающего при ошибке бизнес-логики.
/// </summary>
public class BusinessLogicException : Exception
{
    public BusinessLogicException() : base() { }
    public BusinessLogicException(string message) : base(message) { }
    public BusinessLogicException(string message, Exception innerException) : base(message, innerException) { }

    public BusinessLogicException(string message, params object[] args)
        : base(string.Format(CultureInfo.CurrentCulture, message, args)) { }
}
