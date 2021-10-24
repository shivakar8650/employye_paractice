using System;
using System.Collections.Generic;
using System.Text;

namespace employee_present
{
    class CompanyEmpWage
    {

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void setTotalEmpWage(int totalEmpwage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string toString()
        {
            return "total Emp wage for company :" + this.company + "is:" + this.totalEmpWage;
        }

    }
}
