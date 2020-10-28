using System;
using System.Linq;

namespace FindOccurenceofD
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int d = 2;
            int n = 25;
            int count = 0;
             count = GetOccurence(n, d);
            //bool flag= findd(n, d);
            //int count=0;
            //if (flag ==true)
            //{
            //    count = FindOccurence(n, d);
            //}
            Console.WriteLine(count);
            Console.ReadLine();
        }
         public static int GetOccurence(int n,int d)
        {
            int result = 0;
            int itr = d;
            while(itr <=n)
            {
                if(itr%10==d)
                {
                    result++;
                   
                }
                if(itr!=0 && itr/10 ==d)
                {
                    result++;
                    itr++;
                }
                else if(itr/10 == d-1)
                {
                    itr = (itr + 10) - d;
                }
                else 
                {
                    itr += 10;
                }
            }
            return result;
        }

        //public static bool findd(int n, int d)
        //{
        //    string result = n.ToString();
        //    for(int i =0; i< result.Length;i++)
        //    {
        //        if(result.Contains(d.ToString()))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;

        //}
        //public static int FindOccurence(int n, int d)
        //{
        //    int count = 1;
        //    string rep = d.ToString() + d.ToString();
        //    for(int i=0;i<=n;i++)
        //    {
        //        if(rep == i.ToString())
        //        {
        //            count++;
        //        }
        //        else if(i.ToString().Contains(d.ToString()))
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
        //}
    }
}
