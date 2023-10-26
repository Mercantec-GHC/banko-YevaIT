using System.Security.Cryptography.X509Certificates;

namespace Banko;

public class GameBanko
{
    InputController controller;
    MessageController messageController;
    Plates plates;
    TerminalRender terminalRender;
    string[,] plate;
    int plateNumb;
    

    public GameBanko()
    {
        controller = new InputController();
        messageController = new MessageController();
        terminalRender = new TerminalRender();
        plates = new Plates();
    }



    public void Run()
    {
        // Welcome message and read card number from user

        plateNumb = controller.ReadNum(messageController.GetWelcomeMessage(), 1, 5);
        plate = plates.GetPlate(plateNumb);

        // Show selected card


        while (true)
        {
            terminalRender.ShowPlate(plate);
            int numb = controller.ReadNum(messageController.GetNumberMessage(), 1, 90);
            CheckNumbers(numb);
            switch (CheckRows()) 

       
            {
                case 3:
                terminalRender.ShowMessage(messageController.GetFinishMessage());
                
                break;

                case 2:
                    terminalRender.ShowMessage(messageController.GetWinMessage(2));
                    break;  

                case 1:
                    terminalRender.ShowMessage(messageController.GetWinMessage(1));
                    break;

                
                    
            }
           if (CheckRows() == 3)
            {
                break;
            } 

        }
    }

    public void CheckNumbers(int numb)
    {
        int rows = 3;
        int cols = 9;
        bool numbFound = false;

        string convertedNumber = numb > 9 ? numb.ToString() : " " + numb.ToString();


        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                string selectedPlatesNumber = plate[row, col];
                if (selectedPlatesNumber == convertedNumber)
                {
                    plate[row, col] = " X";
                    numbFound = true;
                }
               
            }
           
        }

        if (!numbFound) 
        {
            terminalRender.ShowMessage(messageController.GetNotExistNumber(plateNumb, numb));
        }
    }

    public int CheckRows() 
    {
        int rows = 3;
        int cols = 9;
        int rowFound = 0;


        for (int row = 0; row < rows; row++)
        {
            bool hasNumb = false;

            for (int col = 0; col < cols; col++)
            {
                string selectedPlatesNumber = plate[row, col];
                if (selectedPlatesNumber != "  " && selectedPlatesNumber != " X")
                {
                    hasNumb = true;
                    
                    break;
                }

            }

            if (!hasNumb) 
            {
                
                rowFound++;
               
            }
            
        }
        
        return rowFound;
    }
}
