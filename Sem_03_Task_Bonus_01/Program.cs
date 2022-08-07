Console.Clear();
Console.WriteLine("Здравствуй, дорогой друг! Давай играть");

while (true)
{

    Console.WriteLine("\nвыбирай: 1-камень 2-ножницы 3-бумага \nдля выхода введи 99! ");
    int user = Convert.ToInt32(Console.ReadLine());
    int comp = new Random().Next(1, 4);

    int userWins = 0;
    int compWins = 0;
    int sumUserWins = 0;
    int sumCompWins = 0;
    int rounds = 0;

    int rock = 1;
    int scissors = 2;
    int paper = 3;
    int exit = 99;

    // rock case
    if (user == rock && comp == scissors)
    {
        Console.WriteLine("\tuser wins!");
        userWins++;
        continue;
    }
    if (user == rock && comp ==  paper)
    {
        Console.WriteLine("\tcomp wins!");
        compWins++;
        continue;
    }
    if (user == rock && comp == rock)
    {
        Console.WriteLine("\tsame choise try again");
        continue;
    }

    //scissors case
    if (user == scissors && comp == paper)
    {
        Console.WriteLine("\tuser wins!");
        userWins++;
        continue;
    }
    if (user == scissors && comp ==  rock)
    {
        Console.WriteLine("\tcomp wins!");
        compWins++;
        continue;
    }
    if (user == scissors && comp == scissors)
    {
        Console.WriteLine("\tsame choise try again");
        continue;
    }

    // paper case

    if (user == paper && comp == rock)
    {
        Console.WriteLine("\tuser wins!");
        userWins++;
        continue;
    }
    if (user == paper && comp ==  scissors)
    {
        Console.WriteLine("\tcomp wins!");
        compWins++;
        continue;
    }
    if (user == paper && comp == paper)
    {
        Console.WriteLine("\tsame choise try again");
        continue;
    }

    //exit case

    if (user == exit)
    {
        rounds++;
        Console.WriteLine($"comp wins {compWins} user wins {userWins} rounds {rounds}");
             
        break;
    }

} 


