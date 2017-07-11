namespace dateMo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public class start
    {
        public static void Main()
        {

            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();
            var result = new dateModifier().DaysDifference(firstDate, secondDate);
            
            Console.WriteLine(result); 
        





        }
    }
}
