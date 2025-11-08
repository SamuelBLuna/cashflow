using CashFlow.Communication.Responses;

namespace CashFlow.Application.UseCase.Expenses.GetExpenseById;
public interface IGetExpenseByIdUseCase
{
    Task<ResponseExpenseJson> Execute(int id);
}
