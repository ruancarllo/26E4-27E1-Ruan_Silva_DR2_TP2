using System;
using Ruan_Silva_DR2_TP2.Exercicio3.ValidadorPlaca;

namespace Ruan_Silva_DR2_TP2.Exercicio1.TesteNormalizacaoPlaca;

public class Program {
    public static void Main() {
        Console.Write("Informe uma placa para normalizar: ");
        string entradaPlaca = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(entradaPlaca)) {
            Console.WriteLine("Erro: nenhuma placa foi informada.");
        } else {
            string placaNormalizada = ValidadorPlaca.NormalizarPlaca(entradaPlaca);
            if (!ValidadorPlaca.PlacaValida(placaNormalizada)) {
                Console.WriteLine($"Erro: placa em formato inválido: {placaNormalizada}");
            } else {
                Console.WriteLine($"Placa normalizada: {placaNormalizada}");
            }
        }

        string[] placasDeTeste = {"ABC1D23", "  def2g45  ", "xyz9a87"};
        foreach (string placa in placasDeTeste) {
            Console.WriteLine($"Placa normalizada: {ValidadorPlaca.NormalizarPlaca(placa)}");
        }
    }
}
