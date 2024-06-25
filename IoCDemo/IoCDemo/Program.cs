
using IoCDemo;

GameManager gm = new GameManager(new HumanPlayer(), new ComputerPlayer());

do
{
    RoundResult result = gm.PlayRound();
    if (result == RoundResult.Player1Win)
    {
        Console.WriteLine("Player 1 win");
    }
    else if (result == RoundResult.Player2Win) 
    { 
        Console.WriteLine("Player 2 win"); 
    }
    else
    {
        Console.WriteLine("Draw");
    }
    Console.WriteLine("play again (Y)");
}while (Console.ReadLine().ToUpper()== "Y");
