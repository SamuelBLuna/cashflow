using CashFlow.Domain.Enums;
using CashFlow.Domain.PaymentMessage;

namespace CashFlow.Domain.Extensions;

public static class PaymentTypeExpensions
{
    public static string PaymentTypeToString(this PaymentType paymentType)
    {
        return paymentType switch
        {
            PaymentType.Cash => ResourcePaymentGenerationType.CASH,
            PaymentType.CreditCard => ResourcePaymentGenerationType.CREDIT_CARD,
            PaymentType.DebitCard => ResourcePaymentGenerationType.DEBIT_CARD,
            PaymentType.EletronicTransfer => ResourcePaymentGenerationType.ELETRONIC_TRANSFER,
            _ => string.Empty
        };

    }
}
