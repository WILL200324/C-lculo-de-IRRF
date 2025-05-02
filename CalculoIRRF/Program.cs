using System;

public class Program
{
    public static void Main()
    {
        // Defina o salário bruto do funcionário
        var funcionario = new Funcionario(3000.00m);

        // Crie o objeto para calcular o INSS
        var inssCalculator = new INSSCalculator();
        decimal descontoINSS = inssCalculator.CalcularDesconto(funcionario.SalarioBruto);

        // Calcule o salário base
        decimal salarioBase = funcionario.SalarioBruto - descontoINSS;

        // Crie o objeto para calcular o IRRF
        var irrfCalculator = new IRRFCalculator();
        decimal irrf = irrfCalculator.CalcularIRRF(salarioBase);

        // Exiba os resultados
        Console.WriteLine($"Salário Bruto: {funcionario.SalarioBruto}");
        Console.WriteLine($"Desconto INSS: {descontoINSS}");
        Console.WriteLine($"Salário Base: {salarioBase}");
        Console.WriteLine($"IRRF: {irrf}");
    }
}


