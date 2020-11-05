using Ado.NetEmployeePayroll;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmployeePayrollMSTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// UC 4 : Given the update salary value check if the database got updated.
        /// </summary>
        [TestMethod]
        public void GivenUpdateSalaryValue_CheckIfTheDatabaseGotUpdated()
        {
            //Arrange
            string empName = "Teressa";
            double basicPay = 40000;
            EmployeeRepository empRepository = new EmployeeRepository();            
            //Act
            empRepository.UpdateSalaryIntoDatabase(empName, basicPay);
            double expectedPay = empRepository.ReadUpdatedSalaryFromDatabase(empName);
            //Assert
            Assert.AreEqual(basicPay, expectedPay);
        }
    }
}
