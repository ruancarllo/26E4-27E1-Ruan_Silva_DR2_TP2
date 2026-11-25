using System;

namespace Ruan_Silva_DR2_TP2.Exercicio4.Veiculo;

public class Program {
    public static void Main() {
        Veiculo veiculo1 = new Veiculo("ABC1D23", DateTime.Now, "carro");
        Veiculo veiculo2 = new Veiculo("DEF2G45", "moto");
        Veiculo veiculo3 = new Veiculo("GHI3J67", "carro");

        foreach (Veiculo veiculo in new[] {veiculo1, veiculo2, veiculo3}) {
            Console.WriteLine(veiculo);
        }
    }
}
