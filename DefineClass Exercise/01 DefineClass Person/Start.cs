﻿namespace DefineClass_Exercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public class Start
    {
        public static void Main()
        {
            Type personType = typeof(Person);

            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);

            Console.WriteLine(fields.Length);

           
           
        }
    }
}
