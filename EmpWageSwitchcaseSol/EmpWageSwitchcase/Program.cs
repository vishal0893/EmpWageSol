using System;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

namespace EmpWage;
class EmpWage
{
    static void Main(string[] args)
    {
        //constant
        const int IS_PART_TIME = 1;
        const int IS_FULL_TIME = 2;
        const int WAGE_PER_HOUR = 20;
        //variables
        int empHrs;
        int empWage;
        Random random = new Random();
        int empCheck = random.Next();
        switch(empCheck)
        {
            case IS_PART_TIME:
                empHrs = 4;
                break;
                case IS_FULL_TIME:
                empHrs = 8;
                break;
                default:
                empHrs = 0;
                break;
        }
        empWage = empHrs * WAGE_PER_HOUR;
        Console.Write("employe wage:" + empWage);

    }
}
