using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsNew
{
    class Program
    {
        public static void Main(string[] args)
        {
            MyList<int> testforpositive = new MyList<int>(10);
            MyList<int> testfornegative = new MyList<int>(10);
            for (int myCount = 0; myCount <= 9; myCount++)
            {
                testforpositive[myCount] = myCount + 1;
            }

            Console.WriteLine("The output when index is positive");

            for (int num = 0; num < 10; num++)
            {
                Console.WriteLine(testforpositive[num]);
            }

            Console.WriteLine("When index given is negative, the output is");

            for (int myCount = 0; myCount >= -9; myCount--)
            {
                testfornegative[myCount] = testforpositive[(myCount * -1)];

            }

            for (int num = 0; num <= 9; num++)
            {
                Console.WriteLine(testfornegative[num]);
            }
            Console.ReadKey();
        }
    }
}

public class MyList<T>
{
    private int size;
    private T[] items;

    public MyList(int size)
    {
        this.size = size;
        this.items = new T[size];
    }

    public T this[int index]
    {
        get
        {
            var item = items[index];
            return item;
        }
        set
        {
            if ((index >= 0) && (index < 9))
                items[index + 1] = value;

            else if ((index <= 0))
                items[10 - (index * -1)] = value;
        }
    }
}



