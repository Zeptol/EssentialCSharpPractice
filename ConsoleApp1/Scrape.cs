using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal static class Scrape
    {
        public static async Task Download()
        {
            var url = "http://www.baidu.com";
            Console.WriteLine(url);

            await Task.Delay(3000);
            var task= WriteWebRequestSizeAsync(url);
            //var ping = new Ping().Send("www.intellitect.com");
            try
            {
                while (!task.Wait(100))
                {
                    Console.Write('.');
                }
            }
            catch (Exception)
            {
                // ignored
            }

            //Console.WriteLine(ping.RoundtripTime);
            //catch (AggregateException e)
            //{
            //    e = e.Flatten();
            //    try
            //    {
            //        e.Handle(innerException =>
            //        {
            //            ExceptionDispatchInfo.Capture(innerException).Throw();
            //            return true;
            //        });
            //    }
            //    catch (Exception exception)
            //    {
            //        Console.WriteLine(exception);
            //        throw;
            //    }
            //}
        }

        private static async Task WriteWebRequestSizeAsync(string url)
        {
            //StreamReader reader = null;
            var webRequest = WebRequest.Create(url);
            var response = await webRequest.GetResponseAsync();
            using (var reader= new StreamReader(response.GetResponseStream() ?? throw new InvalidOperationException()))
            {
                var text = await reader.ReadToEndAsync();
                var header=response.Headers["server"];
                Console.WriteLine(FormatBytes(text.Length));
                Console.WriteLine(header);
            }
            //var task = webRequest.GetResponseAsync().ContinueWith(t =>
            //{
            //    var response = t.Result;

            //    reader = new StreamReader(response.GetResponseStream() ?? throw new InvalidOperationException());

            //    return reader.ReadToEndAsync();
            //}).Unwrap().ContinueWith(t =>
            //{
            //    reader?.Dispose();
            //    var text = t.Result;
            //    Console.WriteLine(FormatBytes(text.Length));
            //});
            //return task;
        }

        private static string FormatBytes(long bytes)
        {
            var magnitudes = new[] {"GB", "MB", "KB", "Bytes"};
            var max = (long) Math.Pow(1024, magnitudes.Length);
            //return
            //    $"{ bytes / (decimal) max} {magnitudes.FirstOrDefault(m => bytes > (max /= 1024)) ?? "0 Bytes"}";
            return string.Format("{1:##.##} {0}", magnitudes.FirstOrDefault(m => bytes > (max /= 1024)) ?? "0 Bytes",
                bytes / (decimal) max);
        }
    }
}
