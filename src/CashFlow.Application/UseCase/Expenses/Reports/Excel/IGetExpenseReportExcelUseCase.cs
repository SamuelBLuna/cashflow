namespace CashFlow.Application.UseCase.Expenses.Reports.Excel;
public interface IGetExpenseReportExcelUseCase
{
    Task<byte[]> Execute(DateOnly month);
}
