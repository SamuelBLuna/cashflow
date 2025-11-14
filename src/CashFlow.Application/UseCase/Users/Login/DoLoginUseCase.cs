using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;
using CashFlow.Domain.Repositories.User;
using CashFlow.Domain.Security.Cryptography;
using CashFlow.Domain.Security.Tokens;
using CashFlow.Exception.ExceptionBase;

namespace CashFlow.Application.UseCase.Users.Login;

public class DoLoginUseCase : IDoLoginUseCase
{
    private readonly IUserReadOnlyRepository _repository;
    private readonly IPasswordEncripter _passwordEncripter;
    private readonly IAccessTokenGenerator _accessTokensGeneration;

    public DoLoginUseCase(
        IUserReadOnlyRepository repository,
        IPasswordEncripter passwordEncripter,
        IAccessTokenGenerator accessTokensGeneration)
    {
        _repository = repository;
        _passwordEncripter = passwordEncripter;
        _accessTokensGeneration = accessTokensGeneration;
    }

    public async Task<ResponseRegisteredUserJson> Execute(RequestLoginJson request)
    {
        var user = await _repository.GetUserByEmail(request.Email);

        if (user is null)
        {
            throw new InvalidLoginException();
        }

        var passwordMatch = _passwordEncripter.Verify(request.Password, user.Password);

        if (!passwordMatch)
        {
            throw new InvalidLoginException();
        }

        return new ResponseRegisteredUserJson
        {
            Name = user.Name,
            Token = _accessTokensGeneration.Genarate(user)
        };
    }
}
