using Criacionais.FactoryMethod.Product;

namespace Criacionais.FactoryMethod.ConcreteProduct;

public class CartaoPlatinum : CreditCard
{
    private readonly string _tipoCartao;
    private int _limiteCredito;
    private int _cobrancaAnual;

    public CartaoPlatinum(int limiteCredito, int cobrancaAnual)
    {
        _tipoCartao = "Platinum";
        _limiteCredito = limiteCredito;
        _cobrancaAnual = cobrancaAnual;
    }

    public override string TipoCartao
    {
        get => _tipoCartao;
    }

    public override int LimiteCredito
    {
        get => _limiteCredito;
        set => _limiteCredito = value;
    }

    public override int CobrancaAnual
    {
        get => _cobrancaAnual;
        set => _cobrancaAnual = value;
    }
}