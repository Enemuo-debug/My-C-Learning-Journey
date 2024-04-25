// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public class CN 
    {
        private int number;
        private bool IsPrime;
        public CN (int number) 
        {
            this.number = number;
            this.IsPrime = IsPrime(number);
        }
        // Creating a getter and a setter
        public int getNumber()
        {
            return this.number;
        }
        public bool checkIfPrime()
        {
            return this.IsPrime;
        }
        public KeyValuePair <int, bool> getBoth () 
        {
            return new KeyValuePair <int, bool> (this.number, this.IsPrime);
        }
        public void setNum (int value) 
        {
            this.number = value;
            this.IsPrime = IsPrime(value);
        }
    }
    public static void Main(string[] args)
    {
        CN Obj = new CN(5);
        Obj.setNum(57);
        Console.WriteLine(Obj.getBoth());
    }
    
    public static bool IsPrime (int num)
    {
        for(int i = 2; i <= (num/2); i++)
        {
            if(num%i == 0)
            {
                return false;
            }
        }
        return true;
    }
}
