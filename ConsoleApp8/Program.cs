using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var a = 4;





            #region MyRegion

            //Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            //Console.WriteLine("Start");
            //Console.WriteLine(Thread.CurrentThread.IsBackground);
            //Thread kazim = new Thread(() =>
            //{
            //    for (int i = 0; i < 5; i++)
            //    {
            //        Thread.Sleep(1000);
            //        string a = "Matrix";
            //        a = "Matrix Acacdemy";
            //    }
            //});
            //kazim.IsBackground = true;
            //Console.WriteLine(kazim.IsBackground);
            //kazim.Start();


            //Console.WriteLine("Finish");
            //Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

            #endregion

            #region Concurrency

            //Console.WriteLine("Starting...");
            //var google = GetWebPageSourceSize("https://www.google.com");
            //var youtube = GetWebPageSourceSize("https://www.youtube.com");

            //await Task.WhenAll(google, youtube);

            //Console.WriteLine("Finish.");

            #endregion

            #region Parallel

            //Parallel.For(0, 10, i =>
            //{
            //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            //    Calculate();
            //});

            #endregion

            #region Async

            //Console.WriteLine("Start");
            //new Thread(() =>
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Thread.Sleep(1000);
            //        //Console.WriteLine("Worker thread runing...");
            //    }

            //}).Start();
            //var getValueResult =  GetValue();
            //Console.WriteLine(getValueResult);
            //Console.WriteLine("Finish");

            #endregion


        }

        public static async Task<int> GetValue()
        {

            return await Task.FromResult(4);
        }


        //public static async Task<string> GetWebPageSourceSize(string url)
        //{
        //    using (HttpClient client = new HttpClient())
        //    {
        //        Console.WriteLine("Start GetWebPageSourceSize");
        //        string result = await client.GetStringAsync(url);
        //        Console.WriteLine($"Success! Page {url} length is " + result.Length);
        //    }
        //}

        //public static void Calculate()
        //{
        //    for (int i = 0; i < 1000000000; i++)
        //    {
        //        i *= int.Parse(Math.Sqrt(i).ToString());
        //    }
        //}

    }
    //Task.FromResult
}
