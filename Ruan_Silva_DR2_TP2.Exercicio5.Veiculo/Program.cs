using System;

namespace Ruan_Silva_DR2_TP2.Exercicio5.Veiculo;

public class Program {
    public static void Main() {
        Veiculo veiculo = new Veiculo("ABC1D23", "carro");
        veiculo.ValorPago = 25.50;

        double valorAntes = veiculo.ValorPago;
        veiculo.ValorPago = -10.0;

        Console.WriteLine($"Valor pago antes da tentativa: {valorAntes:F2}");
        Console.WriteLine($"Valor pago depois da tentativa de atribuir -10.00: {veiculo.ValorPago:F2}");
    }
}
