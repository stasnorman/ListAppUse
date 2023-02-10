using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // FIFO
            Queue<string> students = new Queue<string>();
            students.Enqueue("Иван");
            students.Enqueue("Михаил");
            students.Enqueue("Сергей");
            students.Enqueue("Наталья");

            Console.WriteLine($"Сейчас экзамен сдаёт: {students.Dequeue()}");
            Console.WriteLine($"Следующий готовится к сдаче: {students.Peek()}");
            Console.WriteLine();
            Console.WriteLine("Приготовиться к сдаче:");

            foreach (var item in students)
            {
                Console.WriteLine(item);
            }

                    

            Console.ReadKey();
        }
    }
}
