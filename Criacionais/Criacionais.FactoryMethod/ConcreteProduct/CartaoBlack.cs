﻿using Criacionais.FactoryMethod.Product;

namespace Criacionais.FactoryMethod.ConcreteProduct;

public class CartaoBlack : CreditCard
{
    private readonly string _tipoCartao;
    private int _limiteCredito;
    private int _cobrancaAnual;

    public CartaoBlack(int limiteCredito, int cobrancaAnual)
    {
        _tipoCartao = "Black";
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