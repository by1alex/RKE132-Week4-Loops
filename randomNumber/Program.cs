Random rnd = new Random();

int myRandomNum;

int myRandomSum = 0;


for (int i = 0; i < 10; i++)
{
    myRandomNum = rnd.Next(0, 11); //0 - 10
    myRandomSum = myRandomSum + myRandomNum;
    Console.WriteLine($"My random number is: {myRandomNum}");
}

Console.WriteLine($"Random sum total: {myRandomSum}");