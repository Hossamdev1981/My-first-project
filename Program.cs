using System;

namespace c_review
{
    class Program
    {
        static void Main(string[] args)
        {
            int x =30;
    
           // Console.WriteLine("Hello World!"+x);
            if (x<30){

              Console.WriteLine("x is less than therty");
            }
              else if (x==30)
              {              Console.WriteLine("X is thirty");

              }     
                  else
                  {
                   Console.WriteLine("x is greater than therty");

                  }
              // Let's try an arrarray
                 int[] myarray = new int[5]{3,4,5,6,7};
                 myarray[0]=2;
                Console.WriteLine(myarray[0] );

                for (int i = 0; i < 5 ; i++)
{
                 Console.WriteLine("Array Index"+i+" | Array Value:"+ myarray[i] );
}     
int h=0;

while (h<5)
{
 Console.WriteLine("Array Index"+h+" | Array Value:"+ myarray[h] );
h +=2;

}

foreach (int e in myarray)
{

    Console.WriteLine("current foreach value is:"+e );


}
Console.WriteLine("please enter your name");
string myname = Console.ReadLine();
Console.WriteLine("Thank you, "+myname+"!");




int a = 3;
switch(a){

    case 1 :
         Console.WriteLine("value is 1!");
break;
    case 2 :
         Console.WriteLine("value is 2!");
break;
    case 3 :
         Console.WriteLine("value is 3!");
break;

default :
break;
}

// For a method to execute we must call
Mymethod();

        }

static void Mymethod()
{

Console.WriteLine("test");

}
        
    }
}
