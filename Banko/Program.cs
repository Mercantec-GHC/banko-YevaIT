using Banko;

var platesGenerator = new Plates();
var render = new TerminalRender();

string[,] plate1 = platesGenerator.GetPlate(3);
render.ShowPlate(plate1);


InputController controller = new InputController();
MessageController messageController = new MessageController();

int returnNum = controller.ReadNum(messageController.GetWelcomeMessage(), 1, 5);

render.ShowMessage(messageController.GetWinMessage(2));













