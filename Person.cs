using System;

namespace Events
{
    public class Person
    {
        public event Action GoToSleep;                    //так редко кто делает
        public event EventHandler DoWork;                 //вот так делают чаще
        public string Name { get; set; }

        public void TakeTime(DateTime now)
        {
            if (now.Hour <= 8)
            {
                GoToSleep?.Invoke();
            }
            else
            {
                var args = new EventArgs();
                DoWork?.Invoke(this, null);
            }
        }
    }
}