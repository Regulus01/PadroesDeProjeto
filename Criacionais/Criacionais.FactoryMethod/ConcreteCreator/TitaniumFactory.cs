using Criacionais.FactoryMethod.ConcreteProduct;
using Criacionais.FactoryMethod.Creator;
using Criacionais.FactoryMethod.Product;

namespace Criacionais.FactoryMethod.ConcreteCreator;

public class TitaniumFactory : CartaoFactory
{
    private int _limiteCredito;
    private int _cobrancaAnual;

    public TitaniumFactory(int limiteCredito, int cobrancaAnual)
    {
        _limiteCredito = limiteCredito;
        _cobrancaAnual = cobrancaAnual;
    }

    public override CreditCard CriarCartaoCredito()
    {
        return new CartaoTitanium(_limiteCredito, _cobrancaAnual);
    }
}