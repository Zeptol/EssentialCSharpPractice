using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;
using myTimer = System.Timers.Timer;

namespace ConsoleApp1
{
    internal static class Program
    {
        private const int Repetitions = 1000;

        //public delegate TResult Func<T1, T2, out TResult>(in T1 arg1, in T2 arg2);
        public delegate bool Comparer(int first, int second);

        public static Comparer Compare = (first, second) => first > second;

        private static async Task Main(string[] args)
        {
            Func<int, int, bool> fa = Compare.Invoke;
            myTimer t = new myTimer();
            await Scrape.Download();
            WriteLine(1__2333_4_5);
            WriteLine(6.023E23F);
            WriteLine(float.MaxValue);
            WriteLine(double.MaxValue);
            WriteLine(decimal.MaxValue);
            WriteLine(0x_2002a);
            WriteLine(0b_00101010101);
            WriteLine($"0x{42:x8}");
            WriteLine(Convert.ToString(42, 2));
            WriteLine();
            const double num = 1.618033988749895;
            double res;
            string text;

            text = $"{num}";
            res = double.Parse(text);
            WriteLine($"{res == num}");

            text = $"{num:R}";
            res = double.Parse(text);
            WriteLine($"{res == num}");
            WriteLine($"{num:R}\t{res}");
            WriteLine(string.Compare("SBAA", "sbab", StringComparison.OrdinalIgnoreCase));
            Write('\u003a');
            WriteLine('\u0029');
            WriteLine($@"begin
                            /\
                           /  \{text}
                          /    \
                         /______\
end
");
            var price = 9899.66;
            WriteLine($"{{{price,20:C2} }}");

            unchecked
            {
                var maxInt = int.MaxValue;
                WriteLine(++maxInt);
            }

            var (country, capital, gdp) = ("Malawi", "Lilongwe", 226.50);
            var countryInfo = (country, capital, gdp);
            var cInfo = ("Malawi", Capital: "Lilongwe", 226.50);
            WriteLine($"{countryInfo.country}  {cInfo.Item2}  {gdp}");

            var c = new[] { new[] { 1, 2, 3 }, new[] { 1, 4, 5, 9 } };
            var cells = new[,] { { 1, 2, 3 }, { 1, 4, 9 } };
            c[1][0] = 2;
            var d = c.Clone();
            //Array.Resize(ref cells, 9);
            WriteLine(cells.GetLength(0));
            WriteLine(cells.Rank);

            WriteLine(new string(text.Reverse().ToArray()));
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            string news = new string(charArray);

            var n = '3' + '5';
            WriteLine((char)n);
            float f = -6f;
            WriteLine(f / 0);
            WriteLine(3.4e38f * 2f);

            if (n > 1 || n < 5)
            {
                WriteLine("ok");
            }

            var x1 = -7;
            x1 >>= 2;
            WriteLine(x1);

            byte and = 12, or = 12, xor = 12;
            and &= 7;
            or |= 7;
            xor ^= 7;
            WriteLine($"{and}\t{or}\t{xor}");

            WriteLine(Convert.ToString(9989, 2));

            int a = ~-1;
            goto myLabel;
            a++;
        myLabel: WriteLine(Convert.ToString(a, 2));

            var am = new Cat(20) { StarPoint = 100 };
            TestReference(am);
            WriteLine($"SP after test: {am.StarPoint}");
            var am2 = new Cat(150,99) { StarPoint = 100 };
            var (age, _, starPoint, _) = am2;
            var (j, k, l) = (3, "", '2');
            am2.Deconstruct(out var age2,out _,out var sp,out _);
            WriteLine($"am2 SP={am2.StarPoint}  age={Cat.Age}");
            WriteLine($"am2 SP={starPoint}  age={age}");

            am.Eat();
            Animal.Sleep();
            am.Run();

            WriteLine($"Sp={am.StarPoint}");
            WriteLine(am.Num);
            WriteLine(Animal.Age);
            WriteLine("---------------------------------");
            Cat ct = (Cat)am;
            WriteLine(ct.Num);
            WriteLine(Cat.Age);
            WriteLine(ct.Name);
            ct.Eat();
            Cat.Sleep();
            ct.Run();
            ct.CatchMouse();
            var an = new Animal();
            WriteLine(an.Num);
            var sortArr = new[] { 1, 8, 2, 0, -3, 12, 6 };
            Array.Sort(sortArr);
            Array.Resize(ref sortArr, 10);
            WriteLine(sortArr.Length);
            int? a1 = sortArr?[1];
            foreach (var i in sortArr)
            {
                Write(i + " ");
            }
            WriteLine();
            var o = new object();
            if (o is string str && str.Length > 2)
            {
                int.TryParse(str, out _);
            }
            else if (!(o is Contact))
            {

            }
            switch (o)
            {
                case string str1 when str1.Length > 2:
                    int.TryParse(str1, out _);
                    break;
                case Cat cat when !string.IsNullOrEmpty(cat.Name):
                    break;
                case Contact contact when contact.GetSummary() == "":
                    break;
                case null:
                    break;
            }

            Combine("1", "a", "c");
            string name = default;
            int boxNum = 5;
            object objInt = boxNum;
            object objInt2 = boxNum;
            WriteLine(objInt2==objInt);//装箱后两个变量指向堆上新分配的不同内存地址

            if (Enum.IsDefined(typeof(MyEnum),"A")&&Enum.TryParse("A,C",out MyEnum e))
            {
                WriteLine(e);
            }

            WriteLine(Enum.Parse<DistributedChannel>("FaultTolerant,Transacted").ToString());
            if (Enum.TryParse("Transacted,Queued", out DistributedChannel en))
            {
                WriteLine(en);
            }

            var angle = new Angle();
            var dd = 5.5;
            if (angle)
            {
                WriteLine("angle not initialized");
            }
            angle = dd;
            dd = (double)angle;
            WriteLine(angle);

            using (var cord=new Coordinate())
            {
                
            }
            //Environment.FailFast("aaaaa dafuq");
            try
            {

            }
            catch (Win32Exception win32Exception) when (win32Exception.NativeErrorCode == 42)
            {
                WriteLine(win32Exception);
                throw;
            }
            catch (AggregateException exception)
            {
                exception = exception.Flatten();
                ExceptionDispatchInfo.Capture(exception.InnerException ?? throw new ArgumentNullException()).Throw();
            }
            Beep();
            

            Person.Method(1.0m,2,3);

            IEnumerable<Animal> animals=new Cat[10];//Covariance in array

            //Contravariance
            Action<object> broadAction = WriteLine;
            Action<string> narrowAction = broadAction;

            //Covariance
            Func<string> narrowFunc = ReadLine;
            Func<object> broadFunc = narrowFunc;

            //Contravariance and covariance combined
            Func<object,string> func1=data=>data.ToString();
            Func<string, object> func2 = func1;
            Expression<Func<object, string>> expression = data => data.ToString();
            Expression<Func<int,int,bool>> expression2 = (x,y) => x>y;
            if (expression2.Body is BinaryExpression)
            {
                WriteLine(expression2);
            }
            WriteLine(expression);
            ParameterExpression pe1 = Expression.Parameter(typeof(int), "x");
            ParameterExpression pe2 = Expression.Parameter(typeof(int), "y");
            expression2 = Expression.Lambda<Func<int, int, bool>>(Expression.GreaterThan(Expression.Multiply(pe1,pe2), Expression.Add(pe1,pe2)), pe1, pe2);
            WriteLine(expression2);
            WriteLine(expression2.Compile()(1, 2)); //False
            var pe3 = Expression.Parameter(typeof(object), "data");
            var expression3 = Expression.Lambda<Func<object, string>>(
                Expression.Call(pe3, typeof(object).GetMethod("ToString") ?? throw new InvalidOperationException()),
                pe3);
            WriteLine(expression3);
            WriteLine(expression3.Compile()(123));

            WriteLine("{0,-12:N0}{0}", 12345);//left align with 12 column wide

            LinqExample.GroupKeywords();
            WriteLine();
            LinqExample.GroupKeywords2();
            WriteLine();
            LinqExample.ListMemberNames();
            WriteLine();

            TestBinarySearch();

            var colorMap = new Dictionary<string, ConsoleColor>
            {
                ["Error"] = ConsoleColor.Red,
                ["Warning"] = ConsoleColor.Yellow,
                ["Info"] = ConsoleColor.Green
            };
            colorMap["Verbose"] = ConsoleColor.White;
            colorMap["Error"] = ConsoleColor.Cyan;

            var stack = new Stack<string>();
            stack.Push("qqq");
            var top = stack.Peek();
            using (var enumerator = stack.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    WriteLine(enumerator.Current);
                }
            }

            var q=new Queue<string>();
            q.Enqueue("f");
            WriteLine(q.Dequeue());
            q.TrimExcess();
            var llist=new LinkedList<string>();

            var pair=new Pair<string>("123","45600");
            WriteLine(pair[PairItem.First] + " " + pair[PairItem.Second]);
            WriteLine();

            #region BinaryTree
            var familyTree = new BinaryTree<string>("myself")
            {
                SubItems = new Pair<BinaryTree<string>>(new BinaryTree<string>("father"),
                    new BinaryTree<string>("mother"))
            };
            familyTree.SubItems.First.SubItems = new Pair<BinaryTree<string>>(new BinaryTree<string>("祖父"), new BinaryTree<string>("祖母"));
            familyTree.SubItems.Second.SubItems =
                new Pair<BinaryTree<string>>(new BinaryTree<string>("外祖父"), new BinaryTree<string>("外祖母"));
            //var binaryTree = bTree[PairItem.First, PairItem.Second, PairItem.Second, PairItem.First];
            foreach (var fName in familyTree)
            {
                WriteLine(fName);
            }
            #endregion

            int yield = 1;
            var emptyCollection = Enumerable.Empty<string>();
            var ps=new Pair<string>();
            IPair<object> po =ps;//covariant

            var type = typeof(Nullable<DateTime>);
            WriteLine(type.ContainsGenericParameters);
            WriteLine(type.IsGenericType);
            WriteLine(type.GetGenericArguments().FirstOrDefault());

            //var threadStart=new ThreadStart(DoWork);
            //ThreadPool.QueueUserWorkItem(DoWork,'+');

            //AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            var token = new CancellationTokenSource();
            var task = Task.Run<string>(() => PiCalculator.Calculate(15), token.Token);
            //var task2 = Task.Factory.StartNew(Console.WriteLine, token.Token,
            //    TaskCreationOptions.LongRunning, null);
            ////var task =Task.Run(() => "", token.Token);
            //task.ContinueWith(t => "");
            //WriteLine(Task.CurrentId);//???
            foreach (var busySymbol in Utility.BusySymbols())
            {
                if (task.IsCompleted)
                {
                    Write('\b');
                    break;
                }

                Write(busySymbol);
            }
            task.Wait(token.Token);
            //var faultedTask = task.ContinueWith(t =>
            //{
            //    Trace.Assert(t.IsFaulted);
            //    Console.WriteLine("faulted");
            //}, TaskContinuationOptions.OnlyOnFaulted);

            //var canceledTask = task.ContinueWith(t =>
            //{
            //    Trace.Assert(t.IsCanceled);
            //    Console.WriteLine("canceled");
            //}, TaskContinuationOptions.OnlyOnCanceled);


            //var completedTask = task.ContinueWith(t => {
            //    Trace.Assert(t.IsCompleted);
            //    Console.WriteLine("completed");
            //}, TaskContinuationOptions.OnlyOnRanToCompletion);

            ////completedTask.Wait();
            //try
            //{
            //    //Task.WaitAny(completedTask, faultedTask, canceledTask);
            //    task.Wait(100);
            //}
            //catch (AggregateException e)
            //{
            //    e.Flatten();
            //    e.Handle(exception =>
            //    {
            //        Console.WriteLine($"Error: {exception.Message}");
            //        return true;
            //    });
            //}
            //faultedTask.Wait(token.Token);
            //task.Exception?.Handle(eachException =>
            //{
            //    Console.WriteLine($"Error:{eachException.Message}");
            //    ExceptionDispatchInfo.Capture(eachException).Throw();
            //    return true;
            //});

            WriteLine();
            WriteLine(task.Result);
            Trace.Assert(task.IsCompleted);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            throw new NotImplementedException();
        }

        private static void DoWork(object state)
        {
           var a= ("", 0, default(int));
        }

        private static ref byte FindFirstRedEyePixel(in byte[] img)
        {
            /*img = new byte[9]; //错误, in表示只读传引用*/
            for (var i = 0; i < img.Length; i++)
            {
                if (img[i] == (byte)ConsoleColor.Red)
                {
                    return ref img[i];
                }
            }
            throw new InvalidOperationException("No pixels are red.");
        }

        static string Combine(string c, params string[] args)
        {
            return args.Aggregate(string.Empty, Path.Combine);
        }

        static void TestReference(Cat c)
        {
            c.StarPoint = 1666;
        }

        [return: Description("return attribute")]
        [Obsolete]
        static void TestBinarySearch()
        {
            var list = new List<string> { "public", "protected", "private" };
            list.Sort();
            var search = list.BinarySearch("private protected");
            if (search < 0)
            {
                list.Insert(~search, "private protected");
            }

            foreach (var modifier in list)
            {
                Write($"{modifier}{(list.Last() == modifier ? null : ",")}");
            }
            list.TrimExcess();
            WriteLine();
        }
    }
}
