using Criacionais.FactoryMethod.ConcreteCreator;
using Criacionais.FactoryMethod.Creator;
using Criacionais.FactoryMethod.Product;

CartaoFactory cartaoFactoryBlack;
CartaoFactory cartaoFactoryPlatinum;
CartaoFactory cartaoFactoryTitanium;

cartaoFactoryBlack = new BlackFactory(50000, 0);
cartaoFactoryPlatinum = new PlatinumFactory(10000, 500);
cartaoFactoryTitanium = new TitaniumFactory(500000, 1000);

CreditCard cartao1 = cartaoFactoryBlack.CriarCartaoCredito();
CreditCard cartao2 = cartaoFactoryPlatinum.CriarCartaoCredito();
CreditCard cartao3 = cartaoFactoryTitanium.CriarCartaoCredito();

Console.WriteLine(cartao1.TipoCartao);
Console.WriteLine(cartao2.TipoCartao);
Console.WriteLine(cartao3.TipoCartao);
