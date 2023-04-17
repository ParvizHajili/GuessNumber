
Console.WriteLine("Try to find the number I have in mind");

Random random = new Random();

int randomNumber = random.Next(0, 10);

int guessNum;
bool IsGuessNum = false;

while (!IsGuessNum)
{
    try
    {
        guessNum = Convert.ToInt32(Console.ReadLine());
        while (guessNum == randomNumber)
        {
            Console.Write($"The number was {guessNum}. Conrulations!!!");
            IsGuessNum = true;
            break;
        }
        if (guessNum != randomNumber)
            Console.WriteLine("Try to find again");
    }
    catch (Exception)
    {
        Console.WriteLine("Please Enter only number!!");
    }
}


