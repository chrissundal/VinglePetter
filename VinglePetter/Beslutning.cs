namespace VinglePetter;

public class Beslutning
{
    public void Run()
    {
        Console.Write("Hva skal du ta en beslutning på?: ");
        Console.ReadLine();
        Random random = new Random();
        int randomNumber = random.Next(2);
        int randomTimes = random.Next(3, 7);
        int crashCount = 0;

        while (crashCount < randomTimes)
        {
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("Tenker...");
            int randomCrash = random.Next(2, 10);
            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(random.Next(500, 1501));
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"\r{new string('\u258c', i)} {i * 10}%");
                Console.ResetColor();
                if (i == randomCrash)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Clear();
                    crashCount++;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nOops! Programmet krasjet...");
                    Thread.Sleep(2000);
                    Console.Clear();
                    break;
                }
            }
        }
        Console.ResetColor();
        Console.Clear();

        Console.WriteLine("Tenker...");
        for (int i = 1; i <= 10; i++)
        {
            Thread.Sleep(random.Next(500, 1501));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"\r{new string('\u258c', i)} {i * 10}%");
            Console.ResetColor();
        }

        Console.WriteLine("\nFerdig! Tar en beslutning...");
        Thread.Sleep(random.Next(5000, 15000));
        Console.WriteLine(randomNumber == 0 ? "Svar: Ja" : "Svar: Nei");
        Console.ReadKey();
    }
}