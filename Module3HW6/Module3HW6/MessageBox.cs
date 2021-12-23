using System;
using System.Threading.Tasks;

namespace Module3HW6
{
    public class MessageBox
    {
        public event Action<State> OnClosed;

        public async void Open()
        {
            Console.WriteLine("Window is open");
            await Task.Delay(3000);
            Console.WriteLine("Window is closed");
            var random = new Random().Next(2);
            OnClosed.Invoke((State)random);
        }
    }
}