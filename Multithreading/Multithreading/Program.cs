/*namespace Multithreading
{
    internal class Program
    {*/

        /* static void Main(string[] args)
         {
             Thread t1 = new Thread(new ThreadStart(Func1));
             Thread t2 = new Thread(Func2);

             t1.Start();
             t2.Start();

             for(int i = 0; i < 10; i++)
             {
                 Console.WriteLine(i);
             }
         }*/

        /* static void Main()
         {
             Thread t1 = new Thread(new ThreadStart(Func1));
             Thread t2 = new Thread(Func2);
             t1.IsBackground = true;
             t2.IsBackground = true;



             for (int i = 0; i < 1; i++)
             {
                 Console.WriteLine("Main : " + i);
             }
             t1.Start();
             t2.Start();
             Console.ReadLine();
         }*/

        /* static void Main()
         {
             Thread t1 = new Thread(new ThreadStart(Func1));
             Thread t2 = new Thread(Func2);

             t1.Start();
             t2.Start();

             for (int i = 0; i < 10; i++)
             {
                 Console.WriteLine("Main : " + i);
             }
            t1.Join(); //waiting call - waits for t1 to finish

             Console.WriteLine("code to be run only after Func1 is over");
         }*/

        /*  static void Main1()
          {
              Thread t1 = new Thread(new ThreadStart(Func1));
              Thread t2 = new Thread(Func2);

              t1.Priority = ThreadPriority.Highest;
              t2.Priority = ThreadPriority.Lowest;

              t1.Start();
              t2.Start();

              for (int i = 0; i < 1000; i++)
              {
                  Console.WriteLine("Main : " + i);
              }
          }*/
        /* static void Main5()
         {
             Thread t1 = new Thread(new ThreadStart(Func1));
             Thread t2 = new Thread(Func2);

             //t1.Abort();
             t1.Suspend();
            t1.Resume();
             //if(t1.ThreadState == ThreadState.)
             t1.Start();

             t2.Start();

             for (int i = 0; i < 10; i++)
             {
                 Console.WriteLine("Main : " + i);
                 Thread.Sleep(2000);
             }
         }*/

        /*        static void Main()
                {
                    AutoResetEvent wh = new AutoResetEvent(false);
                    Thread t1 = new Thread(delegate ()
                    {
                        for (int i = 0; i < 200; i++)
                        {
                            Console.WriteLine("f1:" + i);
                            if (i % 50 == 0)
                            {
                                //instead of Suspend, use this
                                Console.WriteLine("waiting");
                                wh.WaitOne();
                            }
                        }
                    });
                    t1.Start();

                    Thread.Sleep(5000);
                    //Console.ReadLine();
                    Console.WriteLine("resuming 1....");
                    wh.Set();

                    Thread.Sleep(5000);
                    //Console.ReadLine();
                    Console.WriteLine("resuming 2....");
                    wh.Set();

                    Thread.Sleep(5000);
                    //Console.ReadLine();
                    Console.WriteLine("resuming 3....");
                    wh.Set();

                    Thread.Sleep(5000);
                    //Console.ReadLine();
                    Console.WriteLine("resuming 4....");
                    wh.Set();
                }
                static void Func1()
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine("First : " + i);
                        Thread.Sleep(2000);
                    }
                }
                static void Func2()
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine("Second : " + i);
                        Thread.Sleep(2000);
                    }
                }
            }
        }*/

    namespace ThreadingExamples2
    {
        internal class Program
        {
            static void Main()
            {
                Thread t1 = new Thread(new ParameterizedThreadStart(Func1));
                Thread t2 = new Thread(Func2);
                t1.Start("aaa");

                //string[] arr = new string[] { "Hello", "World" };
                //t1.Start(arr);
                t2.Start("bbb");

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Main : " + i);
                }
            }
            //1. Tuple/ValueTuple
            //2. create a class/struct and pass an obj of class/struct
            //3. pass an array/collection

            //4. dont pass anything. create an anon method/lambda/local func and access variables declared outside directly
            static void Func1(object obj)
            {
                //string[] arr = (string[])obj;

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("First : " + i + obj.ToString());
                }

            }
            static void Func2(object obj)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Second : " + i + obj.ToString());
                }

            }

        }
    }