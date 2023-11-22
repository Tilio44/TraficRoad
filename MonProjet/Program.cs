using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        for (int i = 0; i < 5; i++)
        {
            int randomValue = RandomNumber.GenerateRandomNumber();

            if (randomValue == 1)
            {
                Console.WriteLine("Le feu est vert");
            }
            else if (randomValue == 2)
            {
                Console.WriteLine("Le feu est rouge");
            }
            else
            {
                Console.WriteLine("La lumière ne fonctionne pas");
            }

            await Task.Delay(500);
        }
    }
}
