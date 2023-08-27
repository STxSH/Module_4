namespace Task_4_4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string Type, int Age, int NameCount) Pet;

            Console.Write("Введите имя питомца: ");
            Pet.Name = Console.ReadLine();
            Pet.NameCount = Pet.Name.Length;

            Console.WriteLine("Введите тип питомца (например, собака, рыбка, хомячок):");
            Pet.Type = Console.ReadLine();

            Console.Write("Введите возраст питомца: ");
            Pet.Age = Convert.ToInt32(Console.ReadLine());

            string year;

            if (Pet.Age % 10 == 1 && Pet.Age != 11)
            { year = "год"; }
            else if (Pet.Age % 10 == 2 && Pet.Age % 10 == 3 && Pet.Age % 10 == 4 && Pet.Age != 12 && Pet.Age != 13 && Pet.Age != 14)
            { year = "года"; }
            else
            { year = "лет"; }
            Console.WriteLine($"У вас {Pet.Type} по кличке {Pet.Name}, возраст вашего питомца {Pet.Age} {year}");

        }
    }
}