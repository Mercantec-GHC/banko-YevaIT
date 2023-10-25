using Banko;

var platesGenerator = new Plates();
var render = new TerminalRender();

string[,] plate1 = platesGenerator.GetPlate(3);
render.ShowPlate(plate1);


InputController controller = new InputController();

int returnNum = controller.ReadNum("Welcome to the Banko game. Please, write number of plate (We have only 5 plates)", 1, 5);













