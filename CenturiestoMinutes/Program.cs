class CenturiestoMinutes
{
    public static void Main(string[] args)
    {
        int century = int.Parse(Console.ReadLine());
            
        int centuryInYears = 100;
        double daysInyear = 365.2422;
       int hoursInday = 24;
        int minutesInHour = 60;


        int years = century * centuryInYears;
        int days = (int) (years * daysInyear);
        int hours = hoursInday *(int) days;
        int minutes = minutesInHour * hours;
        
        Console.WriteLine($"{century} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        
        

    }
}
