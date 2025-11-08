string ginasta;
double notaPartida, notaExecucao, notaFinal;

Console.Write("Nome do ginasta: ");
ginasta = Console.ReadLine()!;
Console.Write("Nota da partida (0.0 - 10.0): ");
notaPartida = double.Parse(Console.ReadLine()!);
Console.Write("Nota da execução (0.0 - 10.0): ");
notaExecucao = double.Parse(Console.ReadLine()!);
notaFinal = (notaPartida * 0.4) + (notaExecucao * 0.6);
Console.WriteLine($"Ginasta: {ginasta}");
Console.WriteLine($"Nota final: {notaFinal:F2}");
