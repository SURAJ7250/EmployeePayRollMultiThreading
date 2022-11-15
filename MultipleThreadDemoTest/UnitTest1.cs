using MultiThreadDemo;

namespace MultipleThreadDemoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenEmployeeAddedtotest()
        {
            List<EmployeeDetail> empdetails = new List<EmployeeDetail>();
            {
                empdetails.Add(new EmployeeDetail(employeeID: 1, employeeName: "Suraj", "7898323", "Manager"));
                empdetails.Add(new EmployeeDetail(employeeID: 1, employeeName: "Aman", "7898323", "Hr"));
                empdetails.Add(new EmployeeDetail(employeeID: 1, employeeName: "Shivam", "7898323", "Technical"));
                empdetails.Add(new EmployeeDetail(employeeID: 1, employeeName: "Shubham", "7898323", "Admin"));
                empdetails.Add(new EmployeeDetail(employeeID: 1, employeeName: "Rahul", "7898323", "Fresher"));

                EmployeePayrollOperation employeepayroll = new EmployeePayrollOperation();
                employeepayroll.AddEmployeeToPayroll(empdetails);

            }
        }
    }
}