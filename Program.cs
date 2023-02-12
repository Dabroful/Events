using System;

namespace Events
{
    internal class Program
    {
        public delegate void MyDelegate(); 
        public event MyDelegate Event;
        public event Action EventAction;
        public static void Main(string[] args)
        {
            Person person = new Person();                             //создали персону
            person.Name = "Вася";
            person.GoToSleep += Person_GoToSleep;                     //подписали на событие 
            person.DoWork += Person_DoWork;
            person.TakeTime(DateTime.Parse("12.02.2023 13:41"));  //вызываем метод два раза
            person.TakeTime(DateTime.Parse("12.02.2023 5:41"));
        }

        private static void Person_DoWork(object sender, EventArgs e)
        {
            if (sender is Person)
            {
                Console.WriteLine($"{((Person)sender).Name} работает работу");
            }
        }

        private static void Person_GoToSleep()
        {
            Console.WriteLine("Человек идет спать");
            Console.ReadLine();
        }
    }
}