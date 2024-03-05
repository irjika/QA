List<int> playerOne = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

List<int> playerTwo = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

while (playerOne.Count > 0 && playerTwo.Count > 0)
{
    int playerOneHand = playerOne[0];
    int playerTwoHand = playerTwo[0];

    if (playerOneHand > playerTwoHand)
    {
        playerOne.Add(playerOneHand);
        playerOne.Add(playerTwoHand);
    }
    else if (playerTwoHand > playerOneHand)
    {
        playerTwo.Add(playerTwoHand);
        playerTwo.Add(playerOneHand);
    }
    playerOne.RemoveAt(0);
    playerTwo.RemoveAt(0);
}

if (playerOne.Count > 0)
{
    Console.WriteLine($"First player wins! Sum: {playerOne.Sum()}");
}
else if (playerTwo.Count > 0)
{
    Console.WriteLine($"Second player wins! Sum: {playerTwo.Sum()}");
}
