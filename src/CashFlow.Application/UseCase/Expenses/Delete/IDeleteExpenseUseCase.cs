namespace CashFlow.Application.UseCase.Expenses.Delete;
public interface IDeleteExpenseUseCase
{
    Task Execute(int id);
}
