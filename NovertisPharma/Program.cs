using System;

namespace NovertisPharma
{
    class Program
    {
        static void Main(string[] args)
        {
            // Medicine med1 = new Medicine("tyu", "Paracetamol", "PZ", 5.00M, 40, new Date(6,4,2021), new Date(6,4,2024), "sdf" );
            // Console.WriteLine("Print()\n");            
            // med1.Print();
            // Console.WriteLine("\nPrint(tyu)\n");            
            // med1.Print("tyu");
            // Console.WriteLine("\nPrint(tyu, Paracetamol)\n");            
            // med1.Print("tyu", "Paracetamol");
            // Console.WriteLine("\nPrint(med1.Restock)\n");            
            // med1.Restock();

            // Medicine med2 = new Medicine("bcomp", "B_Complex", "Tuyil", 10.00M, 0, new Date(16,4,2019), new Date(6,10,2022), "bcp" );
            // Console.WriteLine("Print()\n");            
            // med2.Print();
            // Console.WriteLine("\nPrint(bcomp)\n");            
            // med2.Print("bcomp");
            // Console.WriteLine("\nPrint(bcomp, B_Complex)\n");            
            // med2.Print("bcomp", "B_Complex");
            // Console.WriteLine("\nPrint(med2.Restock)\n");            
            // med2.Restock();

            Sales sales1 = new Sales("Para", 45, 60, 50, "Pain killer");
            Console.WriteLine("Display()\n");
            sales1.Display();
            Console.WriteLine("\nDisplay(Param)\n");
            sales1.Display("Param");

            Sales sales2 = new Sales("bcomp", 15, 30, 20, "Anti-biotics");
            Console.WriteLine("Display()\n");
            sales2.Display();
            Console.WriteLine("\nDisplay(bcomp)\n");
            sales2.Display("bcomp");

        }
    }
}
