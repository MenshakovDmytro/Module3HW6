using System;
using System.Threading.Tasks;

namespace Module3HW6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var messageBox = new MessageBox();
            var tcs = new TaskCompletionSource();

            messageBox.OnClosed += (state) =>
            {
                if (state == State.Ok)
                {
                    Console.WriteLine("Operation confirmed");
                }
                else
                {
                    Console.WriteLine("Operation rejected");
                }

                tcs.SetResult();
            };

            messageBox.Open();
            tcs.Task.GetAwaiter().GetResult();
        }
    }
}
