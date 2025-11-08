using CashFlow.Communication.Responses;

namespace CashFlow.Application.UseCase.Expenses.GetExpenses;
public interface IGetAllExpenseUseCase
{
    Task<ResponseExpensesJson> Execute();
}
