public class IRRFCalculator
{
    public decimal CalcularIRRF(decimal salarioBase)
    {
        if (salarioBase <= 2112.00m)
            return 0.00m;
        else if (salarioBase <= 2826.65m)
            return salarioBase * 0.075m - 169.44m;  // Dedução correta
        else if (salarioBase <= 3751.05m)
            return salarioBase * 0.15m - 370.40m;
        else if (salarioBase <= 4664.68m)
            return salarioBase * 0.225m - 651.73m;
        else
            return salarioBase * 0.275m - 884.96m;
    }
}

