

namespace Banko;

public class MessageController
{
    string welcomeMessage = "Welcome to the Banko game. Please, write number of plate (We have only 5 plates):";
    string winMessage = "Fantastic news! You've just landed %AMOUNT% row in your Banko game. Keep up the great work and aim for even more winning rows in the next round. Happy gaming!";
    string finishMessage = "Congratulations, Banko Champion! You'he landed all plate.";
    string incorrectInputMessage = "Sorry, you entered an invalid number, please try again:";
    string numberMeessage = "Please, write number from 1 to 90:";
    string notExistNumber = "Sorry, your plate number %PLATENUMBER% doesn't includ %NUMB%";

    public string GetWelcomeMessage()
    {
        return welcomeMessage;
    }

    public string GetWinMessage(int amountRows)
    {
        return winMessage.Replace("%AMOUNT%", amountRows.ToString());
    }

    public string GetFinishMessage() 
    {
        return finishMessage;
    }

    public string GetIncorrectInputMessage()
    {
        return incorrectInputMessage;
    }

    public string GetNumberMessage()
    {
        return numberMeessage;
    }

    public string GetNotExistNumber(int plateNumber, int numb)
    {
        return notExistNumber.Replace("%PLATENUMBER%", plateNumber.ToString()).Replace("%NUMB%", numb.ToString());
    }
};









