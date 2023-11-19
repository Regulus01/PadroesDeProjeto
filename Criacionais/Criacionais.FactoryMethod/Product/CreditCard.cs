namespace Criacionais.FactoryMethod.Product;

public abstract class CreditCard
{
    public abstract string TipoCartao { get; }  
    public abstract int LimiteCredito { get; set; }  
    public abstract int CobrancaAnual { get; set; }  
}