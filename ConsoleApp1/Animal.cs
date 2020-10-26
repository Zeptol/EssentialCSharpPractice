using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Animal
    {
        public const float F = 2.34f;
        public virtual int Num => 10;

        public static int Age { get; set; } = 20;
        public int StarPoint { get; set; }

        public virtual void Eat() => Console.WriteLine("Animal eats");

        public static void Sleep() => Console.WriteLine("Animal sleeps");

        public void Run() => Console.WriteLine("Animal runs");
    }

    class Cat : Animal
    {
        public override int Num => 80;
        public new static int? Age { get; private set; } = 90;
        public readonly string Name = "tomcat";
        public string Initials => $"{Age} {Num}";
        public new int StarPoint { get; set; }

        static Cat()
        {
            Age = new Random().Next();
        }

        public Cat(int starPoint, int? age = null)
        {
            (StarPoint, Age) = (starPoint, age);
            Age++;
        }

        public Cat(int starPoint, string name, int? age = null) : this(starPoint, age) => Name = name;

        public override void Eat() => Console.WriteLine("Cat eats");

        public new static void Sleep() => Console.WriteLine("Cat sleeps");

        public void CatchMouse() => Console.WriteLine("Cat catching a mouse");

        public void Deconstruct(out int? age, out int num, out int starPoint, out string initials)
        {
            (age, num, starPoint, initials) = (Age, Num, StarPoint, Initials);
        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Lazy<Stream> FileStreamLazy { get; set; } =
            new Lazy<Stream>(() => new FileStream("", FileMode.OpenOrCreate));

        public static void Method<T>(T first, params T[] values) where T:IComparable<T>
        {

        }

        public static void Show<T>(BinaryTree<T> tree) where T : IComparable<T>
        {

        }
        public Person(string name)
        {

        }
    }

    class SubTree<T,TU>:BinaryTree<T> where T : IComparable<T>
    {
        
    }
    class BinaryTree<T> where T:IComparable<T>
    {
        
    }

    interface ICompareThings<in T>
    {
        bool FirstIsBetter(T t1, T t2);
    }
    class Contact : PdaItem,IListable
    {
        private Person InternalPerson { get; set; }

        public string FirstName
        {
            get => InternalPerson.FirstName;
            set => InternalPerson.FirstName = value;
        }

        public Contact(string name) : base(name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + FirstName;
        }

        public override int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public override string Name { get; set; }
        public override string GetSummary()
        {
            throw new NotImplementedException();
        }

        string[] IListable.ColumnValues { get; set; }
        public void ListItems(string[] arr)
        {
            throw new NotImplementedException();
        }
    }

    abstract class PdaItem:IComparable
    {
        public PdaItem(string name)
        {
            Name = name;
        }
        public virtual string Name { get; set; }
        public abstract string GetSummary();

        public override string ToString()
        {
            return Name;
        }

        public abstract int CompareTo(object obj);
    }

    public interface IListable
    {
        string[] ColumnValues { get; set; }
        void ListItems(string[] arr);
    }

}
