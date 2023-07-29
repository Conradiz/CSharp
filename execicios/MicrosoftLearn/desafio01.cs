using System;
using System.Globalization;

namespace ExercicioCinco
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int employeeLevel = 200;
          string employeeName = "Hariel";

          string title = "";

          switch (employeeLevel){

            case 100: // se employeeLevel = 100
            case 200: 
                title = "Junior Associate";
                break;
            case 300:
                title = "Senior Associate";
                break;
            case 400:
                title = "Manager";
                break;
            case 500: 
                title = "Senior Manager";
                break;
            default:
                title = "Associate";
                break;
          }

          Console.WriteLine($"{employeeName}, {title}");
        }
    }
}