using System;
namespace Wages;
class EmpWage
{
    static void Main(string[] args)
    {
        //CONSTANTS
        int IS_PART_TIME = 1;
        int IS_FULL_TIME = 2;
        int EMM_RATE_PER_HOUR = 20;
        //VARIABLES
        int empHrs = 0;
        int empWage = 0;
        Random random = new Random();
        int empCheck = random.Next(0, 2);
        switch (empCheck)
        {
            case IS_PART_TIME:
                empHrs = 4;
                break;
            case IS_FULL_TIME:
                empHrs = 8;
                break;
            default:
                empHrs = 0;
        }
        empWage = empHrs* EMM_RATE_PER_HOUR;
        Console.WriteLine("Employee wage :" +empWage);
        
    }
}
