using System.Collections;
using System.Collections.Generic;

namespace Gereric
{
    public class Pogram
    {
        public static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("hellow");
            arrayList.Add(true);
            foreach (var i in arrayList)
                Console.WriteLine(i);
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            foreach (int i in list)
                Console.WriteLine(i);
            Dictionary<int,string> dict = new Dictionary<int,string>();
            dict.Add(1, "A");
            dict.Add(2, "B");
            dict.Add(3, "C");
            foreach (var i in dict)
                Console.WriteLine(i);
        }
    }

}