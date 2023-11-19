using Criacionais.FactoryMethod.Product;

namespace Criacionais.FactoryMethod.ConcreteProduct;

public class CartaoTitanium : CreditCard
{
    private readonly string _tipoCartao;
    private int _limiteCredito;
    private int _cobrancaAnual;

    public CartaoTitanium(int limiteCredito, int cobrancaAnual)
    {
        _tipoCartao = "Titanium";
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