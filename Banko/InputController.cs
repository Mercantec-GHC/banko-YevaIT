namespace Banko;




public class InputController
{
    TerminalRender render;
    MessageController messageController;
    public InputController() { 
        render = new TerminalRender();
        messageController = new MessageController();
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
                render.ShowMessage(messageController.GetIncorrectInputMessage());
            }

        }
        return result;

    }
};