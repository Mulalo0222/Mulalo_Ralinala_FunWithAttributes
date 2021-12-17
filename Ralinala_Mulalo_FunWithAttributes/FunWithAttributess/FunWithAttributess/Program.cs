using System;

namespace FunWithAttributess
{
    class Program
    {
       
        static void Main(string[] args)
        {
            InvalidValueAttribute myclass = new InvalidValueAttribute(8)
            {
                Prop1 = 0,
                Prop2 = 16d,
                Prop3 = "text",
                Prop4 = DateTime.Now,
                ShortCircuitOnInvalid = false
            };
            try
            {
                Console.WriteLine("Initial Configuration:");
                if(myclass.isValid)
                {
                    Console.WriteLine("Object IsValid");
                }
                else
                {
                    Console.WriteLine(myclass.InvalidPropertyMessage);
                }
                myclass.Prop4 = myclass.TriggerDate.AddDays(-1);
                Console.WriteLine("After Correcting Prop4 (a date):");
                if(myclass.isValid)
                {
                    Console.WriteLine("Object isValid");
                }
                else
                {
                    Console.WriteLine(myclass.InvalidPropertyMessage);
                }
                myclass.Prop2 = 7d;
                Console.WriteLine("After Correcting Prop2 (a double):");
                if (myclass.isValid)
                {
                    Console.WriteLine("Object isValid");
                }
                else
                {
                    Console.WriteLine(myclass.InvalidPropertyMessage);
                }
            }
           catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();

        }


    }
}
