namespace AsyncAwait
{
    internal class Program
    {
        static async Task Main1()
        {
            Console.WriteLine("Before");
              string message = DoWork(); // itis aBlocking Statement,waiting
            //string message = await DoWorkAsync();//Non Blocking call,waiting
            Console.WriteLine(message);
            Console.WriteLine("After");
            Console.ReadLine();
        }
       // Before 
       //Work Done
         //After
        static async Task<string> DoWorkAsync()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(5000);
                return "Work Done";
            });
        }
        static string DoWork()
        {
            Thread.Sleep(5000);
            return "Work Done";
        }
        static async Task Main()
        {
            Console.WriteLine("Before");
            Task<Task<string>> t1 = new Task<Task<string>>(DoWorkAsync);
            t1.Start();
            Console.WriteLine("After");
            string message = await t1.Result;
            //string message =  t1.Result.Result;
            Console.WriteLine(message);
            Console.ReadLine();
            /*
                        Console.WriteLine("Before");
                        Task<Task<string>> t1 = new Task<Task<string>>(DoWorkAsync);
                        t1.Start();
                        Console.WriteLine("After");
                        string message = await t1.Result;
                        Console.WriteLine(message);
                        Console.ReadLine()*/

        }
    }
}