/// <summary>
/// Exception caused by bad user input.
/// </summary>
public class BadInputException : Exception
{
	public BadInputException() { }

	public BadInputException(string? message) : base(message) { }

	public BadInputException(string? message, Exception? innerException) : base(message, innerException) { }
}
