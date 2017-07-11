namespace dateMo
{
    using System;
    using System.Globalization;

    public class dateModifier
    {
        


        public double DaysDifference(string firstDate, string secondDate)
        {
            var firstDays = DateTime.ParseExact(firstDate, "yyyy MM dd", CultureInfo.InvariantCulture);
            var secondDays = DateTime.ParseExact(secondDate, "yyyy MM dd", CultureInfo.InvariantCulture);

            return Math.Abs((firstDays - secondDays).Days);
            
        
        }
    }
}
