namespace TemplateBaseBe.Exceptions.ExceptionBase;

public class ErrorOnValidationException : TemplateBaseBeException
{
    public IList<string> ErrorMessages { get; set; }
    public ErrorOnValidationException(IList<string> errorMessages) 
    {
        ErrorMessages = errorMessages;
    }
}
