using LapDay3CSharpAdvanced;

namespace LapDay3CSharpAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var department = new Department { DeptID = 1, DeptName = "HR" };
            var employee = new Employee { EmployeeID = 123, Name ="Mohamed" , Salary = 5000 , BirthDate = new DateTime(1960, 1, 1), VacationStock = 10 };

            department.AddStaff(employee);

            employee.EndOfYearOperation();

            employee.RequestVacation(DateTime.Today, DateTime.Today.AddDays(11));
        }
    }
}
