using Criacionais.FactoryMethod.ConcreteProduct;
using Criacionais.FactoryMethod.Creator;
using Criacionais.FactoryMethod.Product;

namespace Criacionais.FactoryMethod.ConcreteCreator;

public class BlackFactory : CartaoFactory
{
    private int _limiteCredito;
    private int _cobrancaAnual;

    public BlackFactory(int limiteCredito, int cobrancaAnual)
    {
        _limiteCredito = limiteCredito;
        _cobrancaAnual = cobrancaAnual;
    }

    public override CreditCard CriarCartaoCredito()
    {
        return new CartaoBlack(_limiteCredito, _cobrancaAnual);
    }
}