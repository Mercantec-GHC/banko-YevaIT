namespace Banko;

public class TerminalRender
{

 

    public void ShowPlate(string[,] plate)
    {
        Console.WriteLine("┌──┬──┬──┬──┬──┬──┬──┬──┬──┐");
        Console.WriteLine($"│{(plate[0, 0])}│{(plate[0, 1])}│{(plate[0, 2])}│{(plate[0, 3])}│{(plate[0, 4])}│{(plate[0, 5])}│{(plate[0, 6])}│{(plate[0, 7])}│{(plate[0, 8])}│");
        Console.WriteLine("├──┼──┼──┼──┼──┼──┼──┼──┼──┤");
        Console.WriteLine($"│{plate[1, 0]}│{plate[1, 1]}│{plate[1, 2]}│{plate[1, 3]}│{plate[1, 4]}│{plate[1, 5]}│{plate[1, 6]}│{plate[1, 7]}│{plate[1, 8]}│");
        Console.WriteLine("├──┼──┼──┼──┼──┼──┼──┼──┼──┤");
        Console.WriteLine($"│{plate[2, 0]}│{plate[2, 1]}│{plate[2, 2]}│{plate[2, 3]}│{plate[2, 4]}│{plate[2, 5]}│{plate[2, 6]}│{plate[2, 7]}│{plate[2, 8]}│");
        Console.WriteLine("└──┴──┴──┴──┴──┴──┴──┴──┴──┘");
    }

    public void ShowMessage(string message) {
        Console.WriteLine(message);
    }
}


