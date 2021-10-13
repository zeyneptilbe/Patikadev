using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            byte b=5; //1 byte
            sbyte c=5;

            short d=5; //2byte
            ushort e=6;
            Int16 f=5; //2 byte
            Int32 g=5; //4 byte
            Int64 h=5; //8 byte
            int i=5; //4 byte
            uint ui=5; 
            long l=5; //8 byte

          //reel sayılar
           float fl=5;  //4 byte
            double db=5;  //8 byte
            decimal dc=5;  //16 byte

            char ch='c';
            string st="zeynep";

            bool b1=true;
            bool b2=false;

            DateTime dt1=DateTime.Now;

            Console.WriteLine(dt1);

            object o1=1;
            object o2=1.5;
            object o3="x";
            object o4='y';


        }
    }
}
