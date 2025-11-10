using CashFlow.Domain.Entities;

namespace CashFlow.Domain.Security.Tokens;
public interface IAccessTokensGeneration
{
    string Genarate(User user);
}
