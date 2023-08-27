namespace Task_module_4_final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string firstName, string lastName, string login, int loginLength, bool havePet, string petName, int age, string[] favoriteColors) user;

            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine($"Анкета пользователя под номером: {j + 1} \n");

                Console.Write("Введите ваше имя: ");
                user.firstName = Console.ReadLine();

                Console.Write("Введите вашу фамилию: ");
                user.lastName = Console.ReadLine();

                Console.Write("Введите ваш логин: ");
                user.login = Console.ReadLine();
                user.loginLength = user.login.Length;

                Console.Write("Введите ваш возраст: ");
                user.age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Есть ли у вас домашнее животное? Ответьте \"Да\" или \"Нет\": ");
                string havePetTemp = Console.ReadLine();

                if (havePetTemp == "Да" || havePetTemp == "да")
                {
                    user.havePet = true;
                    Console.Write("Введите имя вашего питомца: ");
                    user.petName = Console.ReadLine();
                }
                else
                {
                    user.havePet = false;
                    user.petName = "";
                }

                user.favoriteColors = new string[3];

                Console.WriteLine("Введите три цвета, которые вам нравятся (после каждого цвета нажмите клавишу Enter):");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(i + 1 + ". ");
                    user.favoriteColors[i] = Console.ReadLine();
                }

                Console.WriteLine($"\nВаше имя {user.firstName} {user.lastName}, ваш возраст {user.age}," +
                    $" ваш логин {user.login} длинной {user.loginLength} символов.");
                if (user.havePet)
                {
                    Console.WriteLine($"У вас есть питомец, по кличке {user.petName}.");
                }

                Console.Write("Три ваших любимых цвета: ");
                foreach (string i in user.favoriteColors)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}