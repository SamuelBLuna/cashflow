using CashFlow.Domain.Entities;

namespace CashFlow.Domain.Security.Tokens;
public interface IAccessTokensGenaration
{
    string Genarate(User user);
}
