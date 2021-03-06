﻿using System;

namespace LearningCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            byte height = 4;
            byte breadth = 4;
            byte area = (byte) ((int)height + (int) breadth);

            Console.WriteLine("area by byte: " + area);
            int a = 4;
            int b = 4;
            int c = a + b;

            float d = 1.2f;
            float e = 2.4f;

            float f = d + e;
            Console.WriteLine("f: " + f);
            Console.WriteLine("c: " + c);
            Console.WriteLine("Hello World!");

            var g = 10.65; // var sets the respective data type based on the value
            var h = "Apple";
            const float Pi = 3.14f;

            Console.WriteLine("{0},{1},{2}", g, h, Pi);
            Console.WriteLine("formatted string: {0} {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("formatted string: {0} {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("formatted string: {0} {1}", double.MinValue, double.MaxValue);

            string five = "5";
            int Five = Convert.ToInt32(five);
            Console.WriteLine("Five: " + Five);

            int fivE = int.Parse(five);
            Console.WriteLine("fivE: " + fivE);

            TryCatchDemo tryObj = new TryCatchDemo();
            tryObj.TryCatchSample("1234");
            /* 
            checked
            {
                height = 255;
                height += 1;
            }
            */
            Console.WriteLine("Height: " + height);

            ObjInitDemo patient = new ObjInitDemo
            {
                patientFirstName = "Sathish",
                patientId = 7,
                patientLastName = "Kumar"
            };

            Console.WriteLine(patient.patientFirstName + " " + patient.patientLastName);

            Person person = new Person();
            person.personName = "Sathish";
            person.Introduce("Kumar");
            // var buddy = person.clone("Sathish");
            var buddy = Person.clone("Sathish");
            buddy.Introduce("Kumar");
        }
    }
}
