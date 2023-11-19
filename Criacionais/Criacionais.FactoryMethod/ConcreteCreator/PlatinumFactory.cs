using Criacionais.FactoryMethod.ConcreteProduct;
using Criacionais.FactoryMethod.Creator;
using Criacionais.FactoryMethod.Product;

namespace Criacionais.FactoryMethod.ConcreteCreator;

public class PlatinumFactory : CartaoFactory
{
    private int _limiteCredito;
    private int _cobrancaAnual;

    public PlatinumFactory(int limiteCredito, int cobrancaAnual)
    {
        _limiteCredito = limiteCredito;
        _cobrancaAnual = cobrancaAnual;
    }

    public override CreditCard CriarCartaoCredito()
    {
        return new CartaoPlatinum(_limiteCredito, _cobrancaAnual);
    }
}