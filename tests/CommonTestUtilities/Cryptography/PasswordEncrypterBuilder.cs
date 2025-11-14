using CashFlow.Domain.Security.Cryptography;
using Moq;

namespace CommonTestUtilities.Cryptography;

public class PasswordEncrypterBuilder
{
    private readonly Mock<IPasswordEncripter> _mock;
    public PasswordEncrypterBuilder()
    {
        _mock = new Mock<IPasswordEncripter>();
        _mock.Setup(config => config.Encrypt(It.IsAny<string>())).Returns("Samel1234*");
    }

    public PasswordEncrypterBuilder Verify(string? passoword)
    {
        if (!string.IsNullOrWhiteSpace(passoword))
        {
            _mock.Setup(pass => pass.Verify(passoword, It.IsAny<string>())).Returns(true);
        }
        return this;

    }

    public IPasswordEncripter Build() => _mock.Object;
}
