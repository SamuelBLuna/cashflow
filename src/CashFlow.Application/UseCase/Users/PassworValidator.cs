using CashFlow.Exception;
using FluentValidation;
using FluentValidation.Validators;
using System.Text.RegularExpressions;

namespace CashFlow.Application.UseCase.Users;

public partial class PassworValidator<T> : PropertyValidator<T, string>
{

    private const string ERROR_MESSAGE = "ErrorMessage";
    public override string Name => "PasswordValidator";

    protected override string GetDefaultMessageTemplate(string errorCode)
    {
        return "{ErrorMessage}";
    }

    public override bool IsValid(ValidationContext<T> context, string password)
    {
        if(string.IsNullOrWhiteSpace(password))
        {
            context.MessageFormatter.AppendArgument(ERROR_MESSAGE, ResourceErrorMessages.INVALID_PASSWORD);
            return false;
        }

        if(password.Length < 8)
        {
            context.MessageFormatter.AppendArgument(ERROR_MESSAGE, ResourceErrorMessages.INVALID_PASSWORD);
            return false;
        }

        if (!Regex.IsMatch(password, @"[A-Z]+"))
        {
            context.MessageFormatter.AppendArgument(ERROR_MESSAGE, ResourceErrorMessages.INVALID_PASSWORD);
            return false;
        }
        if (!Teste().IsMatch(password))
        {
            context.MessageFormatter.AppendArgument(ERROR_MESSAGE, ResourceErrorMessages.INVALID_PASSWORD);
            return false;
        }
        if (!Regex.IsMatch(password, @"[0-9]+"))
        {
            context.MessageFormatter.AppendArgument(ERROR_MESSAGE, ResourceErrorMessages.INVALID_PASSWORD);
            return false;
        }
        if (!Regex.IsMatch(password, @"[\!\?\*\#\.]+"))
        {
            context.MessageFormatter.AppendArgument(ERROR_MESSAGE, ResourceErrorMessages.INVALID_PASSWORD);
            return false;
        }

        return true;
    }

    [GeneratedRegex(@"[a-z]+")]
    private partial Regex Teste();
}
