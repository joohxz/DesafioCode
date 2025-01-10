public class Program
{
    public static void Main()
    {
        //Teste aqui na main chamando os métodos
    }

    public string Finobacci(int numero)
    {
        var message = string.Empty;
        var formulaInteiroPerfeito = (5 * numero * numero) + 4;

        if (VerificarSeQuadradoPerfeito(numero))
        {
            return message = $"O numéro {numero} é uma sequência de finobacci";
        }
        else { return message = $"O numéro {numero} não é uma sequência de finobacci"; }

        bool VerificarSeQuadradoPerfeito(int num)
        {
            int raiz = (int)Math.Sqrt(num);
            return raiz * raiz == num;
        }
    }

    public string InverterString(string palavra)
    {
        var palavraInvertida = string.Empty;
        char[] palavraChar = palavra.ToCharArray();

        for (int i = palavraInvertida.Length - 1; i >= 0; i--)
        {
            palavraInvertida += palavraChar[i];
        }

        return palavraInvertida;
    }

    public List<double> ResumoMensal()
    {
        var faturamentoMensal = new List<FaturamentoDiario>
    {
        new FaturamentoDiario(1, 22174.1664),
        new FaturamentoDiario(2, 24537.6698),
        new FaturamentoDiario(3, 26139.6134),
        new FaturamentoDiario(4, 0.0),
        new FaturamentoDiario(5, 0.0),
        new FaturamentoDiario(6, 26742.6612),
        new FaturamentoDiario(7, 0.0),
        new FaturamentoDiario(8, 42889.2258),
        new FaturamentoDiario(9, 46251.174),
        new FaturamentoDiario(10, 11191.4722),
        new FaturamentoDiario(11, 0.0),
        new FaturamentoDiario(12, 0.0),
        new FaturamentoDiario(13, 3847.4823),
        new FaturamentoDiario(14, 373.7838),
        new FaturamentoDiario(15, 2659.7563),
        new FaturamentoDiario(16, 48924.2448),
        new FaturamentoDiario(17, 18419.2614),
        new FaturamentoDiario(18, 0.0),
        new FaturamentoDiario(19, 0.0),
        new FaturamentoDiario(20, 35240.1826),
        new FaturamentoDiario(21, 43829.1667),
        new FaturamentoDiario(22, 18235.6852),
        new FaturamentoDiario(23, 4355.0662),
        new FaturamentoDiario(24, 13327.1025),
        new FaturamentoDiario(25, 0.0),
        new FaturamentoDiario(26, 0.0),
        new FaturamentoDiario(27, 25681.8318),
        new FaturamentoDiario(28, 1718.1221),
        new FaturamentoDiario(29, 13220.495),
        new FaturamentoDiario(30, 8414.61)
    };

        double menorValor = double.MaxValue;
        double maiorValor = double.MinValue;
        double soma = 0.0;
        int diasComFaturamento = 0;

        foreach (var faturamento in faturamentoMensal)
        {
            if (faturamento.Valor > 0)
            {
                menorValor = Math.Min(menorValor, faturamento.Valor);
                maiorValor = Math.Max(maiorValor, faturamento.Valor);
                soma += faturamento.Valor;
                diasComFaturamento++;
            }
        }
        double media = soma / diasComFaturamento;

        int diasAcimaDaMedia = 0;
        foreach (var faturamento in faturamentoMensal)
        {
            if (faturamento.Valor > media)
            {
                diasAcimaDaMedia++;
            }
        }

        return new List<double> { menorValor, maiorValor, diasAcimaDaMedia };
    }

    public void PercentualRepresentacao()
    {
        double sp = 67836.43;
        double rj = 36678.66;
        double mg = 29229.88;
        double es = 27165.48;
        double outros = 19849.53;

        double total = sp + rj + mg + es + outros;

        double percentualSP = (sp / total) * 100;
        double percentualRJ = (rj / total) * 100;
        double percentualMG = (mg / total) * 100;
        double percentualES = (es / total) * 100;
        double percentualOutros = (outros / total) * 100;

        Console.WriteLine($"SP: {percentualSP:F2}%");
        Console.WriteLine($"RJ: {percentualRJ:F2}%");
        Console.WriteLine($"MG: {percentualMG:F2}%");
        Console.WriteLine($"ES: {percentualES:F2}%");
        Console.WriteLine($"Outros: {percentualOutros:F2}%");
    }
}