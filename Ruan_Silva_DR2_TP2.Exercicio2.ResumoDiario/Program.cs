using System;

namespace Ruan_Silva_DR2_TP2.Exercicio2.ResumoDiario;

public class Program {
    public static void Main() {
        ImprimirResumo(3, 7.5);
        ImprimirResumo(128, 42.875);
    }

    public static void ImprimirResumo(int totalTickets, double mediaHoras) {
        Console.WriteLine($"Tickets processados: {totalTickets} | Permanência média: {mediaHoras:F2} h");
    }
}
