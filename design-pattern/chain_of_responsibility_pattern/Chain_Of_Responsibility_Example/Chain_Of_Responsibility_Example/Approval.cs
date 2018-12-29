using System;
using System.Collections.Generic;

namespace Chain_Of_Responsibility_Example
{
    class Approval
    {
        static void Main(string[] args)
        {
	        Decimal expenseReportAmount;
			List<Employee> employees = new List<Employee>
            {
				new Employee("foo", Decimal.Zero),
				new Employee("bar", new Decimal(1000)),
				new Employee("hello", new Decimal(5000)),
				new Employee("c#", new Decimal(20000)),
            };

			ExpenseHandler fooHandler = new ExpenseHandler(employees[0]);

        }
    }
}
