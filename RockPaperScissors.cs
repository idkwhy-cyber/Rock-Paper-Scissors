using System;
using System.IO;

Random r1 = new Random();
int computerMoveInt = r1.Next(1,3);

string computerMoveStr;
string playerMoveStr;


if (computerMoveInt == 1)
{
    computerMoveStr = "Rock";
}
else if (computerMoveInt == 2)
{
    computerMoveStr = "Paper";
}
else 
{
    computerMoveStr = "Scissors";
}

Console.WriteLine("Computer has chosen Move, Your turn (1 = rock, 2 = Paper and 3 = Scissors)");
int playerMoveInt = Convert.ToInt32(Console.ReadLine());
if (playerMoveInt == 1)
{
    playerMoveStr = "Rock";
}
else if (playerMoveInt == 2)
{
    playerMoveStr = "Paper";
}
else 
{
    playerMoveStr = "Scissors";
}

DecideWinner(computerMoveInt, playerMoveInt,playerMoveStr ,computerMoveStr);

void Draw(string computerMoveString)
{
    Console.WriteLine("Both Sides Chose " + computerMoveString + " Resulting in a draw");
}

void PlayerWins(string playerMoveString, string computerMoveString)
{
    Console.WriteLine("Player Chose " + playerMoveString + " and computer chose " + computerMoveString + " resulting in player win!");
}

void ComputerWins(string playerMoveString, string computerMoveString)
{
    Console.WriteLine("Player Chose " + playerMoveStr + " and computer chose " + computerMoveInt + " resulting in player loss");
}

void DecideWinner(int computerMoveInteger, int playerMoveInteger, string playerMoveStr, string computerMoveStr)
{
    if (computerMoveInteger != 1)
    {
        if (computerMoveInteger - 1 != playerMoveInteger)
        {
            PlayerWins(playerMoveStr, computerMoveStr);
        }
        else if (computerMoveInteger != playerMoveInteger)
        {
            ComputerWins(playerMoveStr, computerMoveStr);
        }
        else 
        {
            Draw(computerMoveStr);
        }
    }
    else 
    {
        if (playerMoveInteger == 3)
        {
            ComputerWins(playerMoveStr, computerMoveStr);
        }
        else if (computerMoveInteger != playerMoveInteger)
        {
            PlayerWins(playerMoveStr, computerMoveStr);
        }
        else 
        {
            Draw(computerMoveStr);
        }
    }
}

