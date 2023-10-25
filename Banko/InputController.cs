namespace Banko;




public class InputController
{
    TerminalRender render;
    public InputController() { 
        render = new TerminalRender();
    }
    public int ReadNum(string message, int min = 1, int max = 90)
    {
        int result;
        string? rawInput;

        while (true)
        {
            render.ShowMessage(message);
            rawInput = Console.ReadLine();
            bool isNum = int.TryParse(rawInput, out result);
            if (isNum && result >= min && result <= max)
            {
             
                break;
                
            }
            else
            {
                Console.WriteLine("Sorry, you entered an invalid number, please try again");
            }

        }
        return result;

    }
};