namespace Ruan_Silva_DR2_TP2.Exercicio3.ValidadorPlaca;

public static class ValidadorPlaca {
    private const int TamanhoPlaca = 7;

    public static string NormalizarPlaca(string placa) {
        return placa.Trim().ToUpper();
    }

    public static bool PlacaValida(string placaNormalizada) {
        if (placaNormalizada.Length != TamanhoPlaca) {
            return false;
        }

        for (int posicao = 0; posicao < 3; posicao++) {
            if (!LetraMaiuscula(placaNormalizada[posicao])) {
                return false;
            }
        }

        if (!char.IsDigit(placaNormalizada[3])) {
            return false;
        }

        if (!LetraMaiuscula(placaNormalizada[4])) {
            return false;
        }

        return char.IsDigit(placaNormalizada[5]) && char.IsDigit(placaNormalizada[6]);
    }

    public static bool[] PlacaValida(string[] placasNormalizadas) {
        bool[] resultados = new bool[placasNormalizadas.Length];
        for (int indice = 0; indice < placasNormalizadas.Length; indice++) {
            resultados[indice] = PlacaValida(placasNormalizadas[indice]);
        }
        return resultados;
    }

    private static bool LetraMaiuscula(char caractere) {
        return char.IsLetter(caractere) && caractere >= 'A' && caractere <= 'Z';
    }
}
