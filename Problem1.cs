/* Program that prompts the user to input their name, employee number, week ending date, hours worked, rate per hour, standard tax rate, and overtime tax rate.
 * Use this data to calculate gross pay, tax deductions, and net pay.
 * The results should be formatted correctly in a payslip style.
 * Assumptions: Standard working week is 37.5 hours. */

using System;

namespace DBSCADraft
{
    internal class Problem1
    {
        static void Main(string[] args)
        {
            //Asking the user for input and storing it in appropriate variables.
            Console.WriteLine("Welcome to the pay calculator");
            Console.WriteLine("Please enter your name: ");
            string employeeName = Console.ReadLine();
            Console.WriteLine("Please enter your employee number: ");
            string employeeNumber = Console.ReadLine();
            Console.WriteLine("Please enter the week ending date (DD/MM/YYYY): ");
            string wkEndDate = Console.ReadLine();
            Console.WriteLine("Please enter the number of hours worked: ");
            double hoursWorked = Double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your hourly rate: ");
            double hourlyRate = Double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your standard tax rate: ");
            int stdTaxRate = Int32.Parse(Console.ReadLine());

            //Declaring & initialising required variables.
            double overtimeRate = 0.0;
            int otTaxRate = 0;
            double grossPay = 0.0;
            double taxDeductions = 0.0;
            double netPay = 0.0;
            double basePay = 0.0;
            double otHours = 0.0;
            double otPay = 0.0;
            double baseTax = 0.0;
            double otTax = 0.0;

            //If Else logic to determine if the user has worked any overtime.
            if (hoursWorked <= 37.5)
            {
                //Calculating the pay for 37.5 hours worked and setting this value to the gross pay variable.
                basePay = CalculateBasePay(hoursWorked, hourlyRate);
                grossPay = basePay;

                //Calculating tax.
                baseTax = CalculateBaseTax(basePay, stdTaxRate);
                taxDeductions = baseTax;

                //Setting the net pay variable to the sum of gross pay minus tax.
                netPay = grossPay - taxDeductions;
            }
            else if (hoursWorked > 37.5)
            {
                //If the number of hours worked is greater than 37.5, then ask the user to input their overtime details. If the user hasn't worked any overtime then we don't ask them to enter that info.
                Console.WriteLine("Please enter your overtime rate: ");
                overtimeRate = Double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter your overtime tax rate: ");
                otTaxRate = Int32.Parse(Console.ReadLine());

                basePay = 37.5 * hourlyRate;

                //Getting the overtime pay if they've worked more than 37.5 hours.
                otHours = hoursWorked - 37.5;
                otPay = CalculateOvertimePay(otHours, overtimeRate);

                //Setting the gross pay variable to the sum of base pay plus overtime pay.
                grossPay = basePay + otPay;

                //Calculating the total tax.
                baseTax = CalculateBaseTax(basePay, stdTaxRate);
                otTax = CalculateOvertimeTax(otPay, otTaxRate);
                taxDeductions = baseTax + otTax;

                //Setting the net pay variable to the sum of gross pay minus tax.
                netPay = grossPay - taxDeductions;
            }

            //Calling the function to print the payslip to the console.
            PrintPaySlip(wkEndDate, employeeName, employeeNumber, hoursWorked, otHours, hourlyRate, grossPay, otPay, stdTaxRate, baseTax, overtimeRate, otTaxRate, otTax, taxDeductions, netPay);
        }

        //Function to calculate the base pay. Takes the hours worked and hourly rate, returns the base pay.
        public static double CalculateBasePay(double hoursWorked, double hourlyRate)
        {
            double basePay = hoursWorked * hourlyRate;
            return basePay;
        }

        //Function to calculate the base tax. Takes the base pay and standard tax rate, returns the base tax.
        public static double CalculateBaseTax(double basePay, double stdTaxRate)
        {
            double baseTax = (basePay / 100) * stdTaxRate;
            return baseTax;
        }

        //Function to calculate the overtime pay. Takes the overtime hours and overtime rate, returns the overtime pay.
        public static double CalculateOvertimePay(double otHours, double overtimeRate)
        {
            double otPay = otHours * overtimeRate;
            return otPay;
        }

        //Function to calculate the overtime tax. Takees the overtime pay and overtime tax rate, returns the overtime tax.
        public static double CalculateOvertimeTax(double otPay, double otTaxRate)
        {
            double otTax = (otPay / 100) * otTaxRate;
            return otTax;
        }

        //Function to print all details to the console in the required format. Using tabs to format the payslip correctly, and using .ToString("F") as a fixed-point format specifier (formats number with two decimal points).
        public static void PrintPaySlip(string wkEndDate, string employeeName, string employeeNumber, double hoursWorked, double otHours, double hourlyRate, double grossPay, double otPay, double stdTaxRate, double baseTax, double overtimeRate, double otTaxRate, double otTax, double taxDeductions, double netPay)
        {
            Console.WriteLine("\t\t\t\t\tPAYSLIP");
            Console.WriteLine($"WEEK ENDING {wkEndDate}");
            Console.WriteLine($"Employee: {employeeName}");
            Console.WriteLine($"Employee Number: {employeeNumber}");
            Console.WriteLine("\t\t\t\tEarnings\t\tDeductions");
            Console.WriteLine("\t\t\t\tHours\tRate\tTotal");
            Console.WriteLine("Hours (normal)\t\t\t{0}\t{1}\t{2}\tTax @ {3}%\t{4}", (hoursWorked - otHours).ToString("F"), hourlyRate.ToString("F"), (grossPay - otPay).ToString("F"), stdTaxRate, baseTax.ToString("F"));
            Console.WriteLine("Hours (overtime)\t\t{0}\t{1}\t{2}\tTax @ {3}%\t{4}", otHours.ToString("F"), overtimeRate.ToString("F"), otPay.ToString("F"), otTaxRate, otTax.ToString("F"));
            Console.WriteLine("");
            Console.WriteLine($"\t\t\t\tTotal pay:\t\t{grossPay.ToString("F")}");
            Console.WriteLine($"\t\t\t\tTotal deductions:\t{taxDeductions.ToString("F")}");
            Console.WriteLine($"\t\t\t\tNet pay:\t\t{netPay.ToString("F")}");
        }
    }
}
