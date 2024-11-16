using System.Globalization;

namespace CommonLibrary.Exceptions;
/// <summary>
/// Модель исключения, возникающего в слуае, когда объект не найден в базе данных.
/// </summary>
public class ObjectNotFoundException : Exception
{
    public ObjectNotFoundException() : base() { }
    public ObjectNotFoundException(string message) : base(message) { }
    public ObjectNotFoundException(string message, Exception innerException) : base(message, innerException) { }
    public ObjectNotFoundException(string message, params object[] args)
        : base(string.Format(CultureInfo.CurrentCulture, message, args)) { }
}
