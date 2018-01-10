using System;

namespace week4
{
    class Program
    {

        static void Main(string[] args){
            int number = GeefGetal();
            ABFibonachi(number);
          
        }

        static int GeefGetal ()
        {
            Console.WriteLine("Fibonacci sequence");
            int getal = Convert.ToInt32((Console.ReadLine()));
            return getal;
        }    

        static void ABFibonachi(int number){ 
            int[] a = new int [number];
            a[0] = 0;
            a[1] = 1;
            for(int i = 2; i<a.Length; i++){
                a[i]= a[i-1]+a[i-2];
            }
            int teller = 0 ;
            foreach(int j in a){
                Console.WriteLine(a[teller]);
                teller++;
            }
            


            
        }
    }
}