using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;

namespace CashFlow.Application.UseCase.Users.Register;
internal interface IRegisterUserUseCase
{
    Task<ResponseRegisteredUserJson> Execute(RequestRegisterUserJson request);
}
