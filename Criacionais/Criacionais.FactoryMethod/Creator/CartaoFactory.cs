using Criacionais.FactoryMethod.Product;

namespace Criacionais.FactoryMethod.Creator;

public abstract class CartaoFactory
{
    public abstract CreditCard CriarCartaoCredito();
}