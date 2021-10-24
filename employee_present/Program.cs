using System;

namespace employee_present
{
    class Program
    {

       
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();

            empWageBuilder.addCompanyEmpwage("DMart",20,2,10);
            empWageBuilder.addCompanyEmpwage("Reliance", 10, 4, 20);
            empWageBuilder.computeEmpWage();


        }
    }

}
