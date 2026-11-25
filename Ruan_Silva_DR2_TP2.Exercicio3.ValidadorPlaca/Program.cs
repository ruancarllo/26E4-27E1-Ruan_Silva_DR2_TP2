using System;

namespace Ruan_Silva_DR2_TP2.Exercicio3.ValidadorPlaca;

public class Program {
    public static void Main() {
        string[] placas = {"ABC1D23", "  def2g45  ", "AB12C34"};

        string[] placasNormalizadas = new string[placas.Length];
        for (int indice = 0; indice < placas.Length; indice++) {
            placasNormalizadas[indice] = ValidadorPlaca.NormalizarPlaca(placas[indice]);
        }

        bool[] resultados = ValidadorPlaca.PlacaValida(placasNormalizadas);

        for (int indice = 0; indice < placas.Length; indice++) {
            Console.WriteLine($"Placa \"{placasNormalizadas[indice]}\" -> válida: {resultados[indice]}");
        }
    }
}
