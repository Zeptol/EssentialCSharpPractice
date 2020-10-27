using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    interface IPair<out T>
    {
        T First { get;  }
        T Second { get; }
        T this[PairItem index] { get; }
    }

    /**
     * C# 7.2 起可用 readonly 声明只读struct（设计规范：要创建不可变的值类型）
     */
    public readonly struct Pair<T> : IPair<T>,IEnumerable<T> {
        public Pair(T first, T second):this()//对于struct，编译器自动生成默认构造函数将所有字段初始化为默认值
        {
            First = first;
            Second = second;
        }

        public T First { get;  }
        public T Second { get; }

        public T this[PairItem index]
        {
            get
            {
                switch (index)
                {
                    case PairItem.First:
                        return First;
                    case PairItem.Second:
                        return Second;
                    default:
                        throw new NotImplementedException($"The enum {index.ToString()} has not been implemented");
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            yield return First;
            if (Second == null)
            {
                yield break;
            }
            yield return Second;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public enum PairItem
    {
        First,Second
    }
}
