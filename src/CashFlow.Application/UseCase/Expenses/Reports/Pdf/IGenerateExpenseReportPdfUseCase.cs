namespace CashFlow.Application.UseCase.Expenses.Reports.Pdf;

public interface IGenerateExpenseReportPdfUseCase
{
    Task<byte[]> Execute(DateOnly month);
}
