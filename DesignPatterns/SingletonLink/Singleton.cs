using System;
using System.Threading.Tasks;

namespace DesignPatterns.SingletonLink
{
    /// <summary>
    /// 
    /// </summary>
    public class Singleton
    {
        /// <summary>
        /// Singletons the operation.
        /// </summary>
        public static void SingletonOperation()
        {
            try
            {
                Console.WriteLine("Eager Initialization");
                Parallel.Invoke(() => EmployeeDetails(), () => CompanyDetails());

                Console.WriteLine("Lazy Initialization");
                Parallel.Invoke(() => StudentDetails(), () => CollegeDetails());

                Console.WriteLine("ThreadSafe Singleton");
                Parallel.Invoke(() => AccountDetails(), () => BankDetails());

                Console.WriteLine("BillPugh Singleton");
                Parallel.Invoke(() => ManagerDetails(), () => HrDetails());




            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void EmployeeDetails()
        {
            try
            {
                EagerInitialization employee = EagerInitialization.GetInstance;
                employee.PrintDetails("Employee");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void CompanyDetails()
        {
            try
            {
                EagerInitialization company = EagerInitialization.GetInstance;
                company.PrintDetails("Company");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void StudentDetails()
        {
            try
            {
                LazyInitialization student = LazyInitialization.GetInstance;
                student.PrintDetails("Student");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void CollegeDetails()
        {
            try
            {
                LazyInitialization college = LazyInitialization.GetInstance;
                college.PrintDetails("College");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void AccountDetails()
        {
            try
            {
                ThreadSafeSingleton account = ThreadSafeSingleton.GetInstance;
                account.PrintDetails("Account");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void BankDetails()
        {
            try
            {
                ThreadSafeSingleton bank = ThreadSafeSingleton.GetInstance;
                bank.PrintDetails("Bank");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void ManagerDetails()
        {
            try
            {
                BillPughSingleton manager = BillPughSingleton.GetInstance;
                manager.PrintDetails("Manager");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void HrDetails()
        {
            try
            {
                BillPughSingleton hr = BillPughSingleton.GetInstance;
                hr.PrintDetails("Hr");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}