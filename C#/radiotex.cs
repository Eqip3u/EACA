using System;

namespace radiotex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Загадайте число от 1 до 100000 \n\n отвечайте на вопросы да/нет");

            var userChoise = int.Parse(Console.ReadLine()); 

            if (userChoise < 0 || userChoise > 100000)
            {
                Console.WriteLine("ты че загадал пидор, тебе сказали в диапазоне \n\nтеперь и живи с этим \n\n ариведерчи лох");
                Console.ReadKey();
                return;
            }

            var rnd = new Random();

            for (int i = 0; i < 100; i++)
            {
                var compChoise = rnd.Next(1, 100000);

                Console.WriteLine($"Ваше число - {compChoise} ? ");

                var userAnswer = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(userAnswer))
                    Console.WriteLine("ты бы хотя бы что-нибудь написал идиот");

                if (userAnswer == "нет")
                    continue;

                if (userAnswer == "да" && !(userAnswer == userChoise.ToString()))
                {
                    Console.WriteLine("ты че обманщик ? мокрый ганзалес");
                    continue;
                }

                if (userAnswer == "да" && userAnswer == userChoise.ToString())
                {
                    Console.WriteLine($"Компьютер угадал ваше число! \nВыше число = {userChoise}");
                    break;
                }
                if(i == 100)
                    Console.WriteLine("кампуктер не справился с вашим числом =(");
            }
            Console.ReadKey();
        }
    }
}
