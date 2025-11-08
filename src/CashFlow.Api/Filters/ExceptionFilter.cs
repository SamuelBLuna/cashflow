using CashFlow.Communication.Responses;
using CashFlow.Exception;
using CashFlow.Exception.ExceptionBase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CashFlow.Api.Filters;

public class ExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        if(context.Exception is CashFlowException)
        {
            HandleProjetEception(context);
        } else
        {
            ThrowUnkowError(context);
        }
    }

    private void HandleProjetEception(ExceptionContext context)
    {
        var cashFlowException = (CashFlowException)context.Exception;
        context.HttpContext.Response.StatusCode = cashFlowException.StatusCode;

        var errorResponse = new ResponseErrorJson(cashFlowException.GetErros());

        context.Result = new ObjectResult(errorResponse);
    }
    private void ThrowUnkowError(ExceptionContext context)
    {
        var errorResponse = new ResponseErrorJson(ResourceErrorMessages.UNKNOWN_ERROR);

        context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
        context.Result = new ObjectResult(errorResponse);
    }
}
