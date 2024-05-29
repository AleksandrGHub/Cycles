namespace Cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            string message;
            int quantityRepets;

            Console.Write("Напишите слово, которое необходимо повторить: ");
            message = Console.ReadLine();

            Console.Write("Укажите количество повторений: ");
            quantityRepets = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < quantityRepets; i++)
            {
                Console.WriteLine(message);
            }
        }
    }
}