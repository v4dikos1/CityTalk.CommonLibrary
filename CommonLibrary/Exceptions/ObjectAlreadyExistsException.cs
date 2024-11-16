using System.Globalization;

namespace CommonLibrary.Exceptions;
/// <summary>
/// Модель исключения, возникающего в случает, когда объект уже существует в базе данных.
/// </summary>
public class ObjectAlreadyExistsException : Exception
{
    public ObjectAlreadyExistsException() : base() { }
    public ObjectAlreadyExistsException(string message) : base(message) { }
    public ObjectAlreadyExistsException(string message, Exception innerException) : base(message, innerException) { }
    public ObjectAlreadyExistsException(string message, params object[] args)
        : base(string.Format(CultureInfo.CurrentCulture, message, args)) { }
}
