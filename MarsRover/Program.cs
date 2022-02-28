
using MarsRover;

string[] platueSize;
List<string> inputRows = new List<string>();
List<Rover> outputRows = new List<Rover>();

do
{
    Console.WriteLine("Gezegenin boyutunu aralarında boşluk olacak şekilde giriniz (X,Y)");
    platueSize = Console.ReadLine().Split(' ');

} while (platueSize.Length != 2);

var xSize = Convert.ToInt32(platueSize[0]);
var ySize = Convert.ToInt32(platueSize[1]);

Plateau plateau = new Plateau(xSize, ySize);

Console.WriteLine("Araçların bilgilerini giriniz (Hesaplamaya başlamak için 'C' giriniz ! )");
string tempInput;
do
{
    tempInput = Console.ReadLine();
    if (tempInput.Length > 0)
        inputRows.Add(tempInput);
}
while (tempInput.ToUpper() != "C");


Console.WriteLine();
Console.WriteLine();

for (int i = 0; i < inputRows.Count; i += 2)
{
    var locateRow = inputRows[i].Split(' ');
    if(locateRow.Length == 3)
    {
        Rover rover = new Rover(new Coordinate(Convert.ToInt32(locateRow[0]), Convert.ToInt32(locateRow[1])), locateRow[2]);
        var commandRow = inputRows[i + 1].ToUpper().ToList();

        foreach (var command in commandRow)
        {
            switch (command)
            {
                case 'M':
                    if ((rover.GetCoordinates().X <= plateau.xSize && rover.GetCoordinates().Y <= plateau.ySize))
                        rover.Move();
                    break;
                case 'L':
                    rover.TurnLeft();
                    break;
                case 'R':
                    rover.TurnRight();
                    break;
            }
        }
        outputRows.Add(rover);
    }

}

foreach (var row in outputRows)
{
    Console.WriteLine(row);
}

Console.ReadLine();