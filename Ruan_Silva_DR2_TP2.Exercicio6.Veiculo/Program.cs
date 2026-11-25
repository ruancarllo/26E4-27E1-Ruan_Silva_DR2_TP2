using System;

namespace Ruan_Silva_DR2_TP2.Exercicio6.Veiculo;

public class Program {
    public static void Main() {
        Veiculo veiculo = new Veiculo("ABC1D23", "carro");
        veiculo.ValorPago = 25.50;

        ReciboSaida recibo = new ReciboSaida(veiculo.Placa, veiculo.ValorPago);

        Console.WriteLine(veiculo);
        Console.WriteLine(recibo);
    }
}
