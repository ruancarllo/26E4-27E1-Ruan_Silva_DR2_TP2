using System;

namespace Ruan_Silva_DR2_TP2.Exercicio5.Veiculo;

public class Veiculo {
    public string Placa { get; set; }
    public DateTime HorarioEntrada { get; set; }
    public string Tipo { get; set; }

    private double _valorPago;

    public Veiculo(string placa, DateTime horarioEntrada, string tipo) {
        Placa = placa;
        HorarioEntrada = horarioEntrada;
        Tipo = tipo;
    }

    public Veiculo(string placa, string tipo) : this(placa, DateTime.Now, tipo) {
    }

    public double ValorPago {
        get => _valorPago;
        set {
            if (value >= 0) {
                _valorPago = value;
            }
        }
    }

    public override string ToString() {
        return $"Veículo {Placa} | tipo: {Tipo} | entrada: {HorarioEntrada:dd/MM/yyyy HH:mm:ss} | valor pago: {_valorPago:F2}";
    }
}
